using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class LocationController
{
    private Location _location;
    private LocationView _locationView;

    public LocationController(Location location, LocationView locationView)
    {
        _location = location;
        _locationView = locationView;
    }

    public void GetAll()
    {
        var results = _location.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _locationView.List(results, "locations");
        }
    }

    public void GetById()
    {
        var input = _locationView.GetByIdInput();
        var result = _location.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _locationView.Single(result, "location");
        }
    }

    public void Insert()
    {
        var location = new Location();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                location = _locationView.InsertInput();
                if (location.Id == null)
                {
                    Console.WriteLine("Location Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _location.Insert(location);
        _locationView.Transaction(result);
    }

    public void Update()
    {
        var location = new Location();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                location = _locationView.UpdateInput();
                if (location.Id == null)
                {
                    Console.WriteLine("Location Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _location.Update(location);
        _locationView.Transaction(result);
    }

    public void Delete()
    {
        int input = _locationView.DeleteInput();
        var result = _location.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _locationView.Transaction(result);
        }
    }

}
