using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;

public class HistoryView : GeneralView
{
    public int GetByIdInput()
    {
        Console.WriteLine("Enter Employee Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public History InsertInput()
    {
        Console.WriteLine("Enter Start Date to Insert : ");
        DateTime start_date = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter Employee Id to Insert : ");
        int employee_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter End Date to Insert : ");
        DateTime end_date = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter Department Id to Insert : ");
        int department_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Job Id to Insert : ");
        string job_id = Console.ReadLine();

        return new History
        {
            StartDate = start_date,
            EmployeeId = employee_id,
            EndDate = end_date,
            DepartmentId = department_id,
            JobId = job_id
        };
    }

    public History UpdateInput()
    {
        Console.WriteLine("Enter Employee Id to Update : ");
        int employee_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter End Date to Update : ");
        DateTime end_date = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter Department Id to Update : ");
        int department_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Job Id to Update : ");
        string job_id = Console.ReadLine();

        return new History
        {
            EmployeeId = employee_id,
            EndDate = end_date,
            DepartmentId = department_id,
            JobId = job_id
        };
    }

    public int DeleteInput()
    {
        Console.WriteLine("Enter Employee Id to Delete : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
}
