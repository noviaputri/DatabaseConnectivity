namespace DatabaseConnectivity.Views;

public class RegionView : GeneralView
{
    public int GetByIdInput()
    {
        Console.WriteLine("Insert Region Id to View: ");
        var id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public string InsertInput()
    {
        Console.WriteLine("Insert Region Name: ");
        var name = Console.ReadLine();
        return name;
    }

    public Region UpdateInput()
    {
        Console.WriteLine("Insert Region Id to Update: ");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert Region Name to Update: ");
        var name = Console.ReadLine();

        return new Region
        {
            Id = id,
            Name = name
        };
    }

    public int DeleteInput()
    {
        Console.WriteLine("Insert Region Id to Delete: ");
        var id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
}
