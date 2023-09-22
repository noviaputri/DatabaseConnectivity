namespace DatabaseConnectivity.Views;

public class LocationView : GeneralView
{
    public int GetByIdInput()
    {
        Console.WriteLine("Enter Location Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public Location InsertInput()
    {
        Console.WriteLine("Enter Location Id to Insert : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Street Address to Insert : ");
        string street_address = Console.ReadLine();
        Console.WriteLine("Enter Postal Code to Insert : ");
        string postal_code = Console.ReadLine();
        Console.WriteLine("Enter City to Insert : ");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State Province to Insert : ");
        string state_province = Console.ReadLine();
        Console.WriteLine("Enter Country Id to Insert : ");
        string country_id = Console.ReadLine();

        return new Location
        {
            Id = id,
            StreetAddress = street_address,
            PostalCode = postal_code,
            City = city,
            StateProvince = state_province,
            CountryId = country_id
        };
    }

    public Location UpdateInput()
    {
        Console.WriteLine("Enter Location Id to Update : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Street Address to Update : ");
        string street_address = Console.ReadLine();
        Console.WriteLine("Enter Postal Code to Update : ");
        string postal_code = Console.ReadLine();
        Console.WriteLine("Enter City to Update : ");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State Province to Update : ");
        string state_province = Console.ReadLine();
        Console.WriteLine("Enter Country Id to Update : ");
        string country_id = Console.ReadLine();

        return new Location
        {
            Id = id,
            StreetAddress = street_address,
            PostalCode = postal_code,
            City = city,
            StateProvince = state_province,
            CountryId = country_id
        };
    }

    public int DeleteInput()
    {
        Console.WriteLine("Enter Location Id to Delete : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
}
