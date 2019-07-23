using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
	[Route("objects")]
    public class ObjectListController : Controller
    {
		public ObjectListController(IDataRepository repo)
		{
			_repo = repo;
		}

		readonly IDataRepository _repo;

		[HttpGet("")]
		public async Task<ActionResult> GetAllObjects()
        {
			var objects = await _repo.GetAllObjects();
			var vm = new ObjectListViewModel {
				Objects = objects.Select(r => r.ToViewModel()).ToList()
			};
            return View("List", vm);
        }
    }
}