namespace DependencyInjection.Services.Cities;

public class CitiesServices : IcitiesServices
{
    public List<string> _cities;

    public CitiesServices()
    {
        _cities = new List<string>
            {
                "Dhaka",
                "Chattogram",
                "Rajshahi",
                "Khulna",
                "Sylhet",
                "Barishal",
                "Rangpur",
                "Mymensingh"
            };
    }

    public List<string> GetCities()
    {
        return _cities;
    }
}
