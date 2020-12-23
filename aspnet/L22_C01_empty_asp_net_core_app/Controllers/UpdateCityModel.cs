namespace L22_C01_empty_asp_net_core_app.Controllers
{
    public class UpdateCityModel
    {
        public UpdateCityModel(string name, string description, int numberOfPoi)
        {
            Name = name;
            Description = description;
            NumberOfPoi = numberOfPoi;
        }

        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int NumberOfPoi { get; internal set; }
    }
}