using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class EmployeeController
{
    private Employee _employee;
    private EmployeeView _employeeView;

    public EmployeeController(Employee employee, EmployeeView employeeView)
    {
        _employee = employee;
        _employeeView = employeeView;
    }

    public void GetAll()
    {
        var results = _employee.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _employeeView.List(results, "employees");
        }
    }

    public void GetById()
    {
        var input = _employeeView.GetByIdInput();
        var result = _employee.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _employeeView.Single(result, "employee");
        }
    }

    public void Insert()
    {
        var employee = new Employee();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                employee = _employeeView.InsertInput();
                if (employee.Id == null)
                {
                    Console.WriteLine("Employee Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _employee.Insert(employee);
        _employeeView.Transaction(result);
    }

    public void Update()
    {
        var employee = new Employee();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                employee = _employeeView.UpdateInput();
                if (employee.Id == null)
                {
                    Console.WriteLine("Employee Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _employee.Update(employee);
        _employeeView.Transaction(result);
    }

    public void Delete()
    {
        int input = _employeeView.DeleteInput();
        var result = _employee.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _employeeView.Transaction(result);
        }
    }
}
