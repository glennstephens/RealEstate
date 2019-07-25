using RealEstate.Entities;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstate.Services
{
	public interface IDataRepository
	{
		Task<List<Property>> GetFeaturedProperties();
		Task<Property> GetPropertyDetails(int propertyId);
		Task<List<Property>> GetProperties(string searchString, string sortByPropertyName, bool sortAscending);
		Task<Property> UpsertProperty(Property property, bool overwriteAssets);
		Task<Property> DeleteProperty(int id);
	}
}
