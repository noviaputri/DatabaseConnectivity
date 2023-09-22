using DatabaseConnectivity;
using DatabaseConnectivity.Controllers;
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

    /*
    public static bool MenuJob()
    {
        Console.WriteLine("1. Show All Data Job");
        Console.WriteLine("2. Get Job By Id");
        Console.WriteLine("3. Insert Job");
        Console.WriteLine("4. Update Job");
        Console.WriteLine("5. Delete Job");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var job = new Job();

        switch (input)
        {
            case "1":
                var jobs = job.GetAll();
                GeneralView.List(jobs, "jobs");
                return true;
            case "2":
                Console.WriteLine("Enter Job Id : ");
                string JobId = Console.ReadLine();
                Job result = job.GetById(JobId);
                string id = result.Id;
                string title = result.Title;
                int min_salary = result.MinSalary;
                int max_salary = result.MaxSalary;
                Console.WriteLine($"Id: {id}, Title : {title}, Min Salary : {min_salary}, Max Salary : {max_salary}");
                break;
            case "3":
                Console.WriteLine("Enter Job Id to Insert : ");
                string JobIdInsert = Console.ReadLine();
                Console.WriteLine("Enter Title to Insert : ");
                string JobTitleInsert = Console.ReadLine();
                Console.WriteLine("Enter Min Salary to Insert : ");
                int JobMinSalaryInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Max Salary to Insert : ");
                int JobMaxSalaryInsert = Convert.ToInt32(Console.ReadLine());
                var insertResult = job.Insert(JobIdInsert, JobTitleInsert, JobMinSalaryInsert, JobMaxSalaryInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralView.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Job Id to Update : ");
                string JobIdUpdate = Console.ReadLine();
                Console.WriteLine("Enter Title to Update : ");
                string JobTitleUpdate = Console.ReadLine();
                Console.WriteLine("Enter Min Salary to Update : ");
                int JobMinSalaryUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Max Salary to Update : ");
                int JobMaxSalaryUpdate = Convert.ToInt32(Console.ReadLine());
                var updateResult = job.Update(JobIdUpdate, JobTitleUpdate, JobMinSalaryUpdate, JobMaxSalaryUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralView.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Job Id to Delete : ");
                string JobIdDelete = Console.ReadLine();
                var deleteResult = job.Delete(JobIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralView.PerformDelete(resultDelete);
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
        Console.WriteLine("1. Show All Data Department");
        Console.WriteLine("2. Get Department By Id");
        Console.WriteLine("3. Insert Department");
        Console.WriteLine("4. Update Department");
        Console.WriteLine("5. Delete Department");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var department = new Department();

        switch (input)
        {
            case "1":
                var departments = department.GetAll();
                GeneralView.List(departments, "departments");
                return true;
            case "2":
                Console.WriteLine("Enter Department Id : ");
                int DepartmentId = Convert.ToInt32(Console.ReadLine());
                Department result = department.GetById(DepartmentId);
                int id = result.Id;
                string name = result.Name;
                int location_id = result.LocationId;
                int manager_id = result.ManagerId;
                Console.WriteLine($"Id: {id}, Name : {name}, Location Id : {location_id}, Manager Id : {manager_id}");
                break;
            case "3":
                Console.WriteLine("Enter Department Id to Insert : ");
                int DepartmentIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name to Insert : ");
                string DepartmentNameInsert = Console.ReadLine();
                Console.WriteLine("Enter Location Id to Insert : ");
                int DepartmentLocationIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Manager Id to Insert : ");
                int DepartmentManagerIdInsert = Convert.ToInt32(Console.ReadLine());
                var insertResult = department.Insert(DepartmentIdInsert, DepartmentNameInsert, DepartmentLocationIdInsert, DepartmentManagerIdInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralView.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Department Id to Insert : ");
                int DepartmentIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name to Insert : ");
                string DepartmentNameUpdate = Console.ReadLine();
                Console.WriteLine("Enter Location Id to Insert : ");
                int DepartmentLocationIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Manager Id to Insert : ");
                int DepartmentManagerIdUpdate = Convert.ToInt32(Console.ReadLine());
                var updateResult = department.Update(DepartmentIdUpdate, DepartmentNameUpdate, DepartmentLocationIdUpdate, DepartmentManagerIdUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralView.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Department Id to Delete : ");
                int DepartmentIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = department.Delete(DepartmentIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralView.PerformDelete(resultDelete);
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
        Console.WriteLine("1. Show All Data Employee");
        Console.WriteLine("2. Get Employee By Id");
        Console.WriteLine("3. Insert Employee");
        Console.WriteLine("4. Update Employee");
        Console.WriteLine("5. Delete Employee");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var employee = new Employee();

        switch (input)
        {
            case "1":
                var employees = employee.GetAll();
                GeneralView.List(employees, "employees");
                return true;
            case "2":
                Console.WriteLine("Enter Employee Id : ");
                int EmployeeId = Convert.ToInt32(Console.ReadLine());
                Employee result = employee.GetById(EmployeeId);
                int id = result.Id;
                string first_name = result.FirstName;
                string last_name = result.LastName;
                string email = result.Email;
                string phone_number = result.PhoneNumber;
                DateTime hire_date = result.HireDate;
                int salary = result.Salary;
                decimal comission_pct = result.ComissionPct;
                int manager_id = result.ManagerId;
                string job_id = result.JobId;
                int department_id = result.DepartmentId;
                Console.WriteLine($"Id: {id}, First Name : {first_name}, Last Name : {last_name}, " +
                            $"Email : {email}, Phone Number : {phone_number}, Hire Date : {hire_date}, Salary : {salary}," +
                            $"Comission PCT : {comission_pct}, Manager Id : {manager_id}, Job Id : {job_id}, Department Id : {department_id}");
                break;
            case "3":
                Console.WriteLine("Enter Employee Id to Insert : ");
                int EmployeeIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name to Insert : ");
                string EmployeeFirstNameInsert = Console.ReadLine();
                Console.WriteLine("Enter Last Name to Insert : ");
                string EmployeeLastNameInsert = Console.ReadLine();
                Console.WriteLine("Enter Email to Insert : ");
                string EmployeeEmailInsert = Console.ReadLine();
                Console.WriteLine("Enter Phone Number to Insert : ");
                string EmployeePhoneInsert = Console.ReadLine();
                Console.WriteLine("Enter Hire Date to Insert : ");
                DateTime EmployeeHireDateInsert = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Salary to Insert : ");
                int EmployeeSalaryInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Comission PCT to Insert : ");
                decimal EmployeeComissionInsert = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Manager Id to Insert : ");
                int EmployeeManagerIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Job Id to Insert : ");
                string EmployeeJobIdInsert = Console.ReadLine();
                Console.WriteLine("Enter Department Id to Insert : ");
                int EmployeeDepartmentIdInsert = Convert.ToInt32(Console.ReadLine());
                var insertResult = employee.Insert(EmployeeIdInsert, EmployeeFirstNameInsert, EmployeeLastNameInsert, EmployeeEmailInsert, EmployeePhoneInsert, EmployeeHireDateInsert, EmployeeSalaryInsert, EmployeeComissionInsert, EmployeeManagerIdInsert, EmployeeJobIdInsert, EmployeeDepartmentIdInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralView.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Employee Id to Insert : ");
                int EmployeeIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name to Insert : ");
                string EmployeeFirstNameUpdate = Console.ReadLine();
                Console.WriteLine("Enter Last Name to Insert : ");
                string EmployeeLastNameUpdate = Console.ReadLine();
                Console.WriteLine("Enter Email to Insert : ");
                string EmployeeEmailUpdate = Console.ReadLine();
                Console.WriteLine("Enter Phone Number to Insert : ");
                string EmployeePhoneUpdate = Console.ReadLine();
                Console.WriteLine("Enter Hire Date to Insert : ");
                DateTime EmployeeHireDateUpdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Salary to Insert : ");
                int EmployeeSalaryUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Comission PCT to Insert : ");
                decimal EmployeeComissionUpdate = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Manager Id to Insert : ");
                int EmployeeManagerIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Job Id to Insert : ");
                string EmployeeJobIdUpdate = Console.ReadLine();
                Console.WriteLine("Enter Department Id to Insert : ");
                int EmployeeDepartmentIdUpdate = Convert.ToInt32(Console.ReadLine());
                var updateResult = employee.Update(EmployeeIdUpdate, EmployeeFirstNameUpdate, EmployeeLastNameUpdate, EmployeeEmailUpdate, EmployeePhoneUpdate, EmployeeHireDateUpdate, EmployeeSalaryUpdate, EmployeeComissionUpdate, EmployeeManagerIdUpdate, EmployeeJobIdUpdate, EmployeeDepartmentIdUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralView.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Employee Id to Delete : ");
                int EmployeeIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = employee.Delete(EmployeeIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralView.PerformDelete(resultDelete);
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
        Console.WriteLine("1. Show All Data History");
        Console.WriteLine("2. Get History By Employee Id");
        Console.WriteLine("3. Insert History");
        Console.WriteLine("4. Update History");
        Console.WriteLine("5. Delete History");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var history = new History();

        switch (input)
        {
            case "1":
                var histories = history.GetAll();
                GeneralView.List(histories, "histories");
                return true;
            case "2":
                Console.WriteLine("Enter Employee Id : ");
                int EmployeeId = Convert.ToInt32(Console.ReadLine());
                History result = history.GetById(EmployeeId);
                DateTime start_date = result.StartDate;
                int employee_id = result.EmployeeId;
                DateTime end_date = result.EndDate;
                int department_id = result.DepartmentId;
                string job_id = result.JobId;
                Console.WriteLine($"Start Date : {start_date}, Employee Id : {employee_id}, End Date : {end_date}, Department Id : {department_id}, Job Id : {job_id}");
                break;
            case "3":
                Console.WriteLine("Enter Start Date to Insert : ");
                DateTime HistoryStartDateInsert = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Employee Id to Insert : ");
                int HistoryEmployeeIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter End Date to Insert : ");
                DateTime HistoryEndDateInsert = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Department Id to Insert : ");
                int HistoryDepartmentIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Job Id to Insert : ");
                string HistoryJobIdInsert = Console.ReadLine();
                var insertResult = history.Insert(HistoryStartDateInsert, HistoryEmployeeIdInsert, HistoryEndDateInsert, HistoryDepartmentIdInsert, HistoryJobIdInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralView.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Employee Id to Update : ");
                int HistoryEmployeeIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter End Date to Update : ");
                DateTime HistoryEndDateUpdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Department Id to Update : ");
                int HistoryDepartmentIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Job Id to Update : ");
                string HistoryJobIdUpdate = Console.ReadLine();
                var updateResult = history.Update(HistoryEmployeeIdUpdate, HistoryEndDateUpdate, HistoryDepartmentIdUpdate, HistoryJobIdUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralView.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Employee Id to Delete : ");
                int HistoryEmployeeIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = history.Delete(HistoryEmployeeIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralView.PerformDelete(resultDelete);
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
    }*/

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
                //MenuJob();
                AskToGoBackToMenu();
                break;
            case "5":
                Console.Clear();
                //MenuDepartment();
                AskToGoBackToMenu();
                break;
            case "6":
                Console.Clear();
                //MenuEmployee();
                AskToGoBackToMenu();
                break;
            case "7":
                Console.Clear();
                //MenuHistory();
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