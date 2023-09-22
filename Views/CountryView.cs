namespace DatabaseConnectivity.Views;

public class CountryView : GeneralView
{
    public string GetByIdInput()
    {
        Console.WriteLine("Insert Country Id to View: ");
        var id = Console.ReadLine();
        return id;
    }

    public Country InsertInput()
    {
        Console.WriteLine("Enter Country Id to Insert : ");
        string id = Console.ReadLine();
        Console.WriteLine("Enter Country Name to Insert : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Region Id to Insert : ");
        int region_id = Convert.ToInt32(Console.ReadLine());
        
        return new Country
        {
            Id = id,
            Name = name,
            RegionId = region_id
        };
    }

    public Country UpdateInput()
    {
        Console.WriteLine("Enter Country Id to Update : ");
        string id = Console.ReadLine();
        Console.WriteLine("Enter Country Name to Update : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Region Id to Update : ");
        int region_id = Convert.ToInt32(Console.ReadLine());

        return new Country
        {
            Id = id,
            Name = name,
            RegionId = region_id
        };
    }

    public string DeleteInput()
    {
        Console.WriteLine("Enter Country Id to Delete : ");
        string id = Console.ReadLine();
        return id;
    }
}
