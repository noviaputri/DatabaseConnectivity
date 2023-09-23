using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;

public class JobView : GeneralView
{
    public string GetByIdInput()
    {
        Console.WriteLine("Enter Job Id : ");
        string id = Console.ReadLine();
        return id;
    }

    public Job InsertInput()
    {
        Console.WriteLine("Enter Job Id to Insert : ");
        string id = Console.ReadLine();
        Console.WriteLine("Enter Title to Insert : ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Min Salary to Insert : ");
        int min_salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Max Salary to Insert : ");
        int max_salary = Convert.ToInt32(Console.ReadLine());

        return new Job
        {
            Id = id,
            Title = title,
            MinSalary = min_salary,
            MaxSalary = max_salary
        };
    }

    public Job UpdateInput()
    {
        Console.WriteLine("Enter Job Id to Update : ");
        string id = Console.ReadLine();
        Console.WriteLine("Enter Title to Update : ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Min Salary to Update : ");
        int min_salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Max Salary to Update : ");
        int max_salary = Convert.ToInt32(Console.ReadLine());

        return new Job
        {
            Id = id,
            Title = title,
            MinSalary = min_salary,
            MaxSalary = max_salary
        };
    }

    public string DeleteInput()
    {
        Console.WriteLine("Enter Job Id to Delete : ");
        string id = Console.ReadLine();
        return id;
    }
}
