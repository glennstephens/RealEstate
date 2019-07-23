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

		public async Task<List<RealEstateObject>> GetFeaturedObjects()
		{
			var topObjects = await _context
				.RealEstateObjects
				.OrderByDescending(r => r.LastUpdatedUtc)
				.Take(6)
				.ToListAsync();

			return topObjects;
		}

		public async Task<RealEstateObject> GetObjectDetails(int objectId)
		{
			var objectDetails = await _context
				.RealEstateObjects
				.FirstOrDefaultAsync(r => r.Id == objectId);

			return objectDetails;
		}

		public async Task<List<RealEstateObject>> GetAllObjects()
		{
			var objects = await _context
				.RealEstateObjects
				.OrderByDescending(r => r.LastUpdatedUtc)
				.ToListAsync();

			return objects;
		}
	}
}
