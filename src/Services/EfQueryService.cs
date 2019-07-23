using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Services
{
	public class EfDataRepository : IDataRepository
	{
		public EfDataRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		readonly ApplicationDbContext _context;

		public async Task<List<Property>> GetFeaturedProperties()
		{
			var topProperties = await _context
				.Properties
				.OrderByDescending(r => r.LastUpdatedUtc)
				.Take(6)
				.ToListAsync();

			return topProperties;
		}

		public async Task<Property> GetPropertyDetails(int propertyId)
		{
			var propertyDetails = await _context
				.Properties
				.FirstOrDefaultAsync(r => r.Id == propertyId);

			return propertyDetails;
		}

		public Task<List<Property>> GetProperties(string searchString, string sortByPropertyName, bool sortAscending)
		{
			var properties = _context
				.Properties
				.Select(p => p);
				
			if (!string.IsNullOrEmpty(searchString))
			{
				properties = properties
					.Where(
						p => p.Name.Contains(searchString)
						|| p.Description.Contains(searchString)
					);
			}

			if (string.IsNullOrWhiteSpace(sortByPropertyName))
			{
				sortByPropertyName = nameof(Property.LastUpdatedUtc);
			}
			switch (sortByPropertyName.ToLower())
			{
				case "name":
					properties = sortAscending ? properties.OrderBy(p => p.Name) : properties.OrderByDescending(p => p.Name);
					break;
				case "price":
					properties = sortAscending ? properties.OrderBy(p => p.Price) : properties.OrderByDescending(p => p.Price);
					break;
				case "lastupdatedutc":
					properties = sortAscending ? properties.OrderBy(p => p.LastUpdatedUtc) : properties.OrderByDescending(p => p.LastUpdatedUtc);
					break;
			}

			return properties.ToListAsync();
		}
	}
}
