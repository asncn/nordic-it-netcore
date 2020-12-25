﻿namespace L22_C01_empty_asp_net_core_app.Models
{
	public class GetCityModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPoi { get; set; }

		public GetCityModel(int id, string name, string desc, int numberOfPoi)
		{
			Id = id;
			Name = name;
			Description = desc;
			NumberOfPoi = numberOfPoi;
		}
	}
}
