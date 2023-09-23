using DatabaseConnectivity;
using DatabaseConnectivity.Controllers;
using DatabaseConnectivity.Models;
using DatabaseConnectivity.ViewModels;
using DatabaseConnectivity.Views;

namespace BasicConnectivity;

public class Program
{
    public static bool MenuRegion()
    {
        var region = new Region();
        var regionView = new RegionView();
        var regionController = new RegionController(region, regionView);

        Console.WriteLine("1. Show All Data Region");
        Console.WriteLine("2. Get Region By Id");
        Console.WriteLine("3. Insert Region");
        Console.WriteLine("4. Update Region");
        Console.WriteLine("5. Delete Region");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                regionController.GetAll();
                break;
            case "2":
                regionController.GetById();
                break;
            case "3":
                regionController.Insert();
                break;
            case "4":
                regionController.Update();
                break;
            case "5":
                regionController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }
    
    public static bool MenuCountry()
    {
        var country = new Country();
        var countryView = new CountryView();
        var countryController = new CountryController(country, countryView);

        Console.WriteLine("1. Show All Data Country");
        Console.WriteLine("2. Get Country By Id");
        Console.WriteLine("3. Insert Country");
        Console.WriteLine("4. Update Country");
        Console.WriteLine("5. Delete Country");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                countryController.GetAll();
                break;
            case "2":
                countryController.GetById();
                break;
            case "3":
                countryController.Insert();
                break;
            case "4":
                countryController.Update();
                break;
            case "5":
                countryController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    public static bool MenuLocation()
    {
        var location = new Location();
        var locationView = new LocationView();
        var locationController = new LocationController(location, locationView);

        Console.WriteLine("1. Show All Data Location");
        Console.WriteLine("2. Get Location By Id");
        Console.WriteLine("3. Insert Location");
        Console.WriteLine("4. Update Location");
        Console.WriteLine("5. Delete Location");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                locationController.GetAll();
                break;
            case "2":
                locationController.GetById();
                break;
            case "3":
                locationController.Insert();
                break;
            case "4":
                locationController.Update();
                break;
            case "5":
                locationController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    public static bool MenuJob()
    {
        var job = new Job();
        var jobView = new JobView();
        var jobController = new JobController(job, jobView);

        Console.WriteLine("1. Show All Data Job");
        Console.WriteLine("2. Get Job By Id");
        Console.WriteLine("3. Insert Job");
        Console.WriteLine("4. Update Job");
        Console.WriteLine("5. Delete Job");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                jobController.GetAll();
                break;
            case "2":
                jobController.GetById();
                break;
            case "3":
                jobController.Insert();
                break;
            case "4":
                jobController.Update();
                break;
            case "5":
                jobController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    public static bool MenuDepartment()
    {
        var department = new Department();
        var departmentView = new DepartmentView();
        var departmentController = new DepartmentController(department, departmentView);

        Console.WriteLine("1. Show All Data Department");
        Console.WriteLine("2. Get Department By Id");
        Console.WriteLine("3. Insert Department");
        Console.WriteLine("4. Update Department");
        Console.WriteLine("5. Delete Department");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                departmentController.GetAll();
                break;
            case "2":
                departmentController.GetById();
                break;
            case "3":
                departmentController.Insert();
                break;
            case "4":
                departmentController.Update();
                break;
            case "5":
                departmentController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    public static bool MenuEmployee()
    {
        var employee = new Employee();
        var employeeView = new EmployeeView();
        var employeeController = new EmployeeController(employee, employeeView);

        Console.WriteLine("1. Show All Data Employee");
        Console.WriteLine("2. Get Employee By Id");
        Console.WriteLine("3. Insert Employee");
        Console.WriteLine("4. Update Employee");
        Console.WriteLine("5. Delete Employee");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                employeeController.GetAll();
                break;
            case "2":
                employeeController.GetById();
                break;
            case "3":
                employeeController.Insert();
                break;
            case "4":
                employeeController.Update();
                break;
            case "5":
                employeeController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    public static bool MenuHistory()
    {
        var history = new History();
        var historyView = new HistoryView();
        var historyController = new HistoryController(history, historyView);

        Console.WriteLine("1. Show All Data History");
        Console.WriteLine("2. Get History By Employee Id");
        Console.WriteLine("3. Insert History");
        Console.WriteLine("4. Update History");
        Console.WriteLine("5. Delete History");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                historyController.GetAll();
                break;
            case "2":
                historyController.GetById();
                break;
            case "3":
                historyController.Insert();
                break;
            case "4":
                historyController.Update();
                break;
            case "5":
                historyController.Delete();
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    static void AskToGoBackToMenu()
    {
        Console.Write("Do you want to go back to the menu? (yes/no): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            // Clear the console and return to the menu
            Console.Clear();
        }
        else
        {
            // Exit the program
            Environment.Exit(0);
        }
    }

    public static bool MainMenu(string input)
    {
        // Create instances of the Employee and Department classes
        var employee = new Employee();
        var department = new Department();
        // Get all employees and departments
        var getEmployee = employee.GetAll();
        var getDepartment = department.GetAll();

        switch (input)
        {
            case "1":
                Console.Clear();
                MenuRegion();
                AskToGoBackToMenu();
                break;
            case "2":
                Console.Clear();
                MenuCountry();
                AskToGoBackToMenu();
                break;
            case "3":
                Console.Clear();
                MenuLocation();
                AskToGoBackToMenu();
                break;
            case "4":
                Console.Clear();
                MenuJob();
                AskToGoBackToMenu();
                break;
            case "5":
                Console.Clear();
                MenuDepartment();
                AskToGoBackToMenu();
                break;
            case "6":
                Console.Clear();
                MenuEmployee();
                AskToGoBackToMenu();
                break;
            case "7":
                Console.Clear();
                MenuHistory();
                AskToGoBackToMenu();
                break;
            case "8":
                // LINQ to Show Data A
                // Create instances of the Location, Country, and Region classes
                var location = new Location();
                var country = new Country();
                var region = new Region();

                // Get all locations, countries, and regions
                var getLocation = location.GetAll();
                var getCountry = country.GetAll();
                var getRegion = region.GetAll();

                // Join the Employee, Department, Location, Country, and Region data
                var resultJoinA =
                    (from e in getEmployee
                    join d in getDepartment on e.DepartmentId equals d.Id
                    join l in getLocation on d.LocationId equals l.Id
                    join c in getCountry on l.CountryId equals c.Id
                    join r in getRegion on c.RegionId equals r.Id
                    // Creating a new instance of the JoinAVM class and selecting all its properties
                    select new JoinAVM
                    {
                        EmployeeId = e.Id,
                        FullName = e.FirstName + " " + e.LastName,
                        Email = e.Email,
                        Phone = e.PhoneNumber,
                        Salary = e.Salary,
                        DepartmentName = d.Name,
                        StreetAddress = l.StreetAddress,
                        CountryName = c.Name,
                        RegionName = r.Name
                    }).ToList();
                // Display the result using the GeneralMenu.List method
                GeneralView generalViewA = new GeneralView();
                generalViewA.List(resultJoinA, "Data A");
                break;
            case "9":
                // LINQ to Show Data B 
                // Join the Employee and Department data
                var resultJoinB = 
                    (from e in getEmployee
                     join d in getDepartment on e.DepartmentId equals d.Id
                     // Group the employees by department name
                     group e by d.Name into employeeDepartments
                     // Filter the groups to only include those with a count greater than 3
                     where employeeDepartments.Count() > 3
                     // Creating a new instance of the JoinBVM class and selecting all its properties
                     select new JoinBVM
                     {
                         DepartmentName = employeeDepartments.Key,
                         TotalEmployee = employeeDepartments.Count(),
                         MinSalary = employeeDepartments.Min(e => e.Salary),
                         MaxSalary = employeeDepartments.Max(e => e.Salary),
                         AverageSalary = employeeDepartments.Average(e => e.Salary)
                     }).ToList();
                // Display the result using the GeneralMenu.List method
                GeneralView generalViewB = new GeneralView();
                generalViewB.List(resultJoinB, "Data B");
                break;
            case "10":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }

    private static void Main()
    {
        var choice = true;
        
        while (choice)
        {
            Console.WriteLine("Choose Table to CRUD");
            Console.WriteLine("======================");
            Console.WriteLine("1. Regions");
            Console.WriteLine("2. Countries");
            Console.WriteLine("3. Locations");
            Console.WriteLine("4. Jobs");
            Console.WriteLine("5. Departments");
            Console.WriteLine("6. Employees");
            Console.WriteLine("7. Histories");
            Console.WriteLine("8. Show Employee LINQ");
            Console.WriteLine("9. Show Query LINQ");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");
            var input = Console.ReadLine();
            choice = MainMenu(input);
        }
        Console.WriteLine("Goodbye!");
    }
}