using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
	[Route("properties")]
    public class PropertiesListController : Controller
    {
		public PropertiesListController(IDataRepository repo)
		{
			_repo = repo;
		}

		readonly IDataRepository _repo;

		[HttpGet("")]
		public async Task<ActionResult> GetAllProperties()
        {
			var properties = await _repo.GetAllProperties();
			var vm = new PropertyListViewModel {
				Properties = properties.Select(r => r.ToViewModel()).ToList()
			};
            return View("List", vm);
        }
    }
}