using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;

public class DepartmentView : GeneralView
{
    public int GetByIdInput()
    {
        Console.WriteLine("Enter Department Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public Department InsertInput()
    {
        Console.WriteLine("Enter Department Id to Insert : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name to Insert : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Location Id to Insert : ");
        int location_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Manager Id to Insert : ");
        int manager_id = Convert.ToInt32(Console.ReadLine());

        return new Department
        {
            Id = id,
            Name = name,
            LocationId = location_id,
            ManagerId = manager_id
        };
    }

    public Department UpdateInput()
    {
        Console.WriteLine("Enter Department Id to Insert : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name to Insert : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Location Id to Insert : ");
        int location_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Manager Id to Insert : ");
        int manager_id = Convert.ToInt32(Console.ReadLine());

        return new Department
        {
            Id = id,
            Name = name,
            LocationId = location_id,
            ManagerId = manager_id
        };
    }

    public int DeleteInput()
    {
        Console.WriteLine("Enter Department Id to Delete : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
}
