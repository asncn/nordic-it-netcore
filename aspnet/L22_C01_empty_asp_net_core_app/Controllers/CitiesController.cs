using System.Collections.Generic;
using System.Linq;
using L22_C01_empty_asp_net_core_app.DataStore;
using L22_C01_empty_asp_net_core_app.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;



namespace L22_C01_empty_asp_net_core_app.Controllers
{
	[Route("/api/cities")]
	public class CitiesController : Controller
	{
		private static CitiesDataStore _dataStore = new CitiesDataStore();
        private object patchCityDoc;

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

		[HttpPost("{id}")]
		public IActionResult AddCity(int id,[FromBody] UpdateCityModel updateCityModel)
		{
			if (updateCityModel == null)
				return BadRequest();

			// newId = _dataStore.GetNewId();

			City city = _dataStore
				.Cities
				.FirstOrDefault(c => c.Id == id);

			if (city == null)
				return NotFound();

			city.Name = updateCityModel.Name;
			city.Description = updateCityModel.Description;
			city.NumberOfPoi = updateCityModel.NumberOfPoi;

			return NoContent();

			//addCityModel.Description,
			//	addCityModel.NumberOfPoi);

			//_dataStore.Cities.Add(city);

			//var getCityModel = new GetCityModel(
			//	newId,
			//	addCityModel.Name,
			//addCityModel.Description,
			//addCityModel.NumberOfPoi);

			//return CreatedAtAction(
			//	"GetCity",
			//	new {id = newId},
			//	getCityModel);
			
		}


		[HttpPatch("{id}")]
		public IActionResult PatchCity(
				int id, [FromBody] JsonPatchDocument<PatchCityModel> patchCityModel)
		{

			if (patchCityModel == null)
				return BadRequest();

			// newId = _dataStore.GetNewId();

			City city = _dataStore
				.Cities
				.FirstOrDefault(c => c.Id == id);

			if (city == null)
				return NotFound();

			var updateCityModel = new UpdateCityModel(city.Name, city.Description, city.NumberOfPoi);
			//patchCity.Doc.ApplyTo(updateCityModel);

			return NoContent();

			if (city.Name != updateCityModel.Name)
				city.Name = updateCityModel.Name;

			if (city.Description != updateCityModel.Description)
				city.Description = updateCityModel.Description;

			if (city.NumberOfPoi != updateCityModel.NumberOfPoi)
				city.NumberOfPoi = updateCityModel.NumberOfPoi;

		}
	}
}
