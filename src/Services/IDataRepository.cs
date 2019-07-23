using RealEstate.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstate.Services
{
	public interface IDataRepository
	{
		Task<List<RealEstateObject>> GetFeaturedObjects();
		Task<RealEstateObject> GetObjectDetails(int objectId);
		Task<List<RealEstateObject>> GetProperties(string searchString, string sortByPropertyName, bool sortAscending);
	}
}
