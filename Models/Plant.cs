namespace PlanMap.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public string Description { get; set; }

        //private Plant() { }

        public Plant Create(double latitude, double longitude, string description)
        {
            return new Plant
            {
                Lat = latitude,
                Long = longitude,
                Description = description
            };

            //Plant plant = new Plant();
            //plant.Latitude = latitude;
            //plant.Longitude = longitude;
            //plant.Description = description;

            //return plant;
        }
    }


}
