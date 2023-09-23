using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class DepartmentController
{
    private Department _department;
    private DepartmentView _departmentView;

    public DepartmentController(Department department, DepartmentView departmentView)
    {
        _department = department;
        _departmentView = departmentView;
    }

    public void GetAll()
    {
        var results = _department.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _departmentView.List(results, "departments");
        }
    }

    public void GetById()
    {
        var input = _departmentView.GetByIdInput();
        var result = _department.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _departmentView.Single(result, "department");
        }
    }

    public void Insert()
    {
        var department = new Department();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                department = _departmentView.InsertInput();
                if (department.Id == null)
                {
                    Console.WriteLine("Department Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _department.Insert(department);
        _departmentView.Transaction(result);
    }

    public void Update()
    {
        var department = new Department();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                department = _departmentView.UpdateInput();
                if (department.Id == null)
                {
                    Console.WriteLine("Department Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _department.Update(department);
        _departmentView.Transaction(result);
    }

    public void Delete()
    {
        int input = _departmentView.DeleteInput();
        var result = _department.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _departmentView.Transaction(result);
        }
    }
}
