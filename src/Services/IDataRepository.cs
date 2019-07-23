using RealEstate.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstate.Services
{
	public interface IDataRepository
	{
		Task<List<Property>> GetFeaturedProperties();
		Task<Property> GetPropertyDetails(int propertyId);
		Task<List<Property>> GetAllProperties();
	}
}
