using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class CountryController
{
    private Country _country;
    private CountryView _countryView;

    public CountryController(Country country, CountryView countryView)
    {
        _country = country;
        _countryView = countryView;
    }

    public void GetAll()
    {
        var results = _country.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _countryView.List(results, "countries");
        }
    }

    public void GetById()
    {
        var input = _countryView.GetByIdInput();
        var result = _country.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _countryView.Single(result, "country");
        }
    }

    public void Insert()
    {
        var country = new Country();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                country = _countryView.InsertInput();
                if (string.IsNullOrEmpty(country.Id))
                {
                    Console.WriteLine("Country Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*
        var result = _country.Insert(new Country
        {
                Id = country.Id,
                Name = country.Name,
                RegionId = country.RegionId,
        });*/
        var result = _country.Insert(country);
        _countryView.Transaction(result);
    }

    public void Update()
    {
        var country = new Country();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                country = _countryView.UpdateInput();
                if (string.IsNullOrEmpty(country.Id))
                {
                    Console.WriteLine("Country Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _country.Update(country);
        _countryView.Transaction(result);
    }

    public void Delete()
    {
        string input = _countryView.DeleteInput();
        var result = _country.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _countryView.Transaction(result);
        }
    }
}
