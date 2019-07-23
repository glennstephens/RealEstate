using RealEstate.Entities;

namespace RealEstate.Models
{
	public class PropertyViewModel: BaseViewModel
	{
		public Property Property { get; set; }
		public string ImageUrl { get; set; }
	}
}
