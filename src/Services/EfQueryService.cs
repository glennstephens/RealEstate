using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Entities;
using System;
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

		public async Task<List<Property>> GetAllProperties()
		{
			var properties = await _context
				.Properties
				.OrderByDescending(r => r.LastUpdatedUtc)
				.ToListAsync();

			return properties;
		}
	}
}
