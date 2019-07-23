using RealEstate.Entities;
using RealEstate.Models;
using System;
using System.Collections.Generic;

namespace RealEstate
{
	public static class RealEstateHelpers
	{
		public static PropertyViewModel ToViewModel(this Property property) => new PropertyViewModel {
			Property = property,
			ImageUrl = $"/assets/propertyimages/property-{property.Id}.jpg"
		};

		internal static List<Property> CreateProperties()
		{
			var data = new List<Property>();

			for (int i = 1; i < 100; i++)
			{
				data.Add(new Property {
					Name = "Property " + i,
					NumberOfBathrooms = i,
					NumberOfBedrooms = i + 1,
					Id = i,
					Price = i * 10000,
					Description = "This is a beautiful property. Look at its ID of " + i,
					LastUpdatedUtc = DateTimeOffset.UtcNow.AddDays(-i),
					HasAirConditioning = i % 2 == 0,
					HasBalcony = i % 3 == 0,
					HasBroadband = i % 5 == 0,
					HasFloorboards = i % 7 == 0,
					HasRemoteGarage = i % 13 == 0
				}) ;
			}

			return data;
		}
	}
}