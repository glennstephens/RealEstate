using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

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

		[HttpGet("", Name = "GetProperties")]
		public async Task<ActionResult> GetProperties(int? page, string searchString, string sortBy, bool sortAscending)
		{
			if (page == null || page <= 0)
			{
				page = 1;
			}
			var properties = await _repo.GetProperties(searchString, sortBy, sortAscending);

			var vm = new PropertyListViewModel {
				CurrentPage = page.Value,
				SearchString = searchString,
				SortAscending = sortAscending,
				SortBy = sortBy
			};

			vm.Properties = properties
				.Select(p => p.ToViewModel())
				.ToPagedList(vm.CurrentPage, vm.ObjectsPerPage);

			return View("List", vm);
		}
	}
}