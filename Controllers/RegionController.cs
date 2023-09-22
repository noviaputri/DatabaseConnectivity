using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class RegionController
{
    private Region _region;
    private RegionView _regionView;

    public RegionController(Region region, RegionView regionView)
    {
        _region = region;
        _regionView = regionView;
    }

    public void GetAll()
    {
        var results = _region.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _regionView.List(results, "regions");
        }
    }

    public void GetById()
    {
        int input = _regionView.GetByIdInput();
        var result = _region.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _regionView.Single(result, "regions");
        }
    }

    public void Insert()
    {
        string input = "";
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                input = _regionView.InsertInput();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Region name cannot be empty");
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
        var result = _region.Insert(new Region
        {
            Id = 0,
            Name = input
        });*/
        var result = _region.Insert(input);
        _regionView.Transaction(result);
    }

    public void Update()
    {
        var region = new Region();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                region = _regionView.UpdateInput();
                if (string.IsNullOrEmpty(region.Name))
                {
                    Console.WriteLine("Region name cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _region.Update(region);
        _regionView.Transaction(result);
    }

    public void Delete()
    {
        int input = _regionView.DeleteInput();
        var result = _region.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _regionView.Transaction(result);
        }
    }
}