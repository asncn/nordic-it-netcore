using System.Collections.Generic;
using System.Linq;
using L22_C01_empty_asp_net_core_app.DataStore;
using L22_C01_empty_asp_net_core_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace L22_C01_empty_asp_net_core_app.Controllers
{
	[Route("/api/cities")]
	public class CitiesController : Controller
	{
		private static CitiesDataStore _dataStore = new CitiesDataStore();

		[HttpGet]
		public IActionResult GetCities()
		{
			List<City> cities = _dataStore.Cities;
			if (cities == null)
				return NotFound();

			List<GetCityModel> models = cities
				.Select(c => new GetCityModel(
					c.Id,
					c.Name,
					c.Description,
					c.NumberOfPoi))
				.ToList();

			return Ok(models);
		}

		[HttpGet("{id}")]
		public IActionResult GetCity(int id)
		{
			City city = _dataStore
				.Cities
				.FirstOrDefault(c => c.Id == id);

			if (city == null)
				return NotFound();
			
			var model = new GetCityModel(
				city.Id,
				city.Name,
				city.Description,
				city.NumberOfPoi);

			return Ok(model);
		}

		[HttpPost]
		public IActionResult AddCity([FromBody] AddCityModel addCityModel)
		{
			if (addCityModel == null)
				return BadRequest();

			int newId = _dataStore.GetNewId();

			var city = new City(
				newId,
				addCityModel.Name,
				addCityModel.Description,
				addCityModel.NumberOfPoi);

			_dataStore.Cities.Add(city);

			var getCityModel = new GetCityModel(
				newId,
				addCityModel.Name,
				addCityModel.Description,
				addCityModel.NumberOfPoi);

			return CreatedAtAction(
				"GetCity",
				new {id = newId},
				getCityModel);
		}
	}
}
