namespace StarWarsAPI.Models
{
    public enum Category
    {
        people,
        films,
        planets,
        species,
        starships,
        vehicles
    }
    public class RequestData
    {
        public string URL { get; set; }
        public Category Category { get; set; }
    }
}
