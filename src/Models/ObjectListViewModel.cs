﻿using System.Collections.Generic;
using RealEstate.Entities;
using X.PagedList;

namespace RealEstate.Models
{
	public class PropertyListViewModel : BaseViewModel
	{
		public string SortBy { get; set; } = nameof(RealEstateObject.LastUpdatedUtc);
		public bool SortAscending { get; set; } = false;
		public int CurrentPage { get; set; } = 1;
		public int ObjectsPerPage { get; set; } = 10;
		public string SearchString { get; set; } = null;
		public IPagedList<RealEstateObjectViewModel> Properties { get; set; }
	}
}
