using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;

public class EmployeeView : GeneralView
{
    public int GetByIdInput()
    {
        Console.WriteLine("Enter Employee Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public Employee InsertInput()
    {
        Console.WriteLine("Enter Employee Id to Insert : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter First Name to Insert : ");
        string first_name = Console.ReadLine();
        Console.WriteLine("Enter Last Name to Insert : ");
        string last_name = Console.ReadLine();
        Console.WriteLine("Enter Email to Insert : ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Phone Number to Insert : ");
        string phone_number = Console.ReadLine();
        Console.WriteLine("Enter Hire Date to Insert : ");
        DateTime hire_date = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter Salary to Insert : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Comission PCT to Insert : ");
        decimal comission_pct = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Manager Id to Insert : ");
        int manager_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Job Id to Insert : ");
        string job_id = Console.ReadLine();
        Console.WriteLine("Enter Department Id to Insert : ");
        int department_id = Convert.ToInt32(Console.ReadLine());

        return new Employee
        {
            Id = id,
            FirstName = first_name,
            LastName = last_name, 
            Email = email,
            PhoneNumber = phone_number,
            HireDate = hire_date,
            Salary = salary,
            ComissionPct = comission_pct,
            ManagerId = manager_id,
            JobId = job_id,
            DepartmentId = department_id
        };
    }

    public Employee UpdateInput()
    {
        Console.WriteLine("Enter Employee Id to Update : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter First Name to Update : ");
        string first_name = Console.ReadLine();
        Console.WriteLine("Enter Last Name to Update : ");
        string last_name = Console.ReadLine();
        Console.WriteLine("Enter Email to Update : ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Phone Number to Update : ");
        string phone_number = Console.ReadLine();
        Console.WriteLine("Enter Hire Date to Update : ");
        DateTime hire_date = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter Salary to Update : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Comission PCT to Update : ");
        decimal comission_pct = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Manager Id to Update : ");
        int manager_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Job Id to Update : ");
        string job_id = Console.ReadLine();
        Console.WriteLine("Enter Department Id to Update : ");
        int department_id = Convert.ToInt32(Console.ReadLine());

        return new Employee
        {
            Id = id,
            FirstName = first_name,
            LastName = last_name,
            Email = email,
            PhoneNumber = phone_number,
            HireDate = hire_date,
            Salary = salary,
            ComissionPct = comission_pct,
            ManagerId = manager_id,
            JobId = job_id,
            DepartmentId = department_id
        };
    }

    public int DeleteInput()
    {
        Console.WriteLine("Enter Employee Id to Delete : ");
        int id = Convert.ToInt32(Console.ReadLine());
        return id;
    }
}
