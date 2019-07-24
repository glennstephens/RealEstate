using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Controllers
{
	[Route("properties")]
	public class PropertyDetailsController : Controller
    {
        public PropertyDetailsController(IDataRepository repo)
		{
			_repo = repo;
		}

		readonly IDataRepository _repo;


		[Route("{propertyId}")]
        public async Task<IActionResult> Details(int propertyId)
        {
			var propertyDetails = await _repo.GetPropertyDetails(propertyId);

			var vm = propertyDetails.ToViewModel();

			return View(vm);
        }
    }
}
