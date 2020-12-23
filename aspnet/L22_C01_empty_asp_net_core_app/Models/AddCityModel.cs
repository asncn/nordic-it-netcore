﻿namespace L22_C01_empty_asp_net_core_app.Models
{
	public class AddCityModel
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPoi { get; set; }

		public AddCityModel()
		{
		}

		public AddCityModel(string name, string desc, int numberOfPoi)
		{
			Name = name;
			Description = desc;
			NumberOfPoi = numberOfPoi;
		}
	}
}
