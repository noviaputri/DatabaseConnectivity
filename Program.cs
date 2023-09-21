namespace BasicConnectivity;

public class Program
{
    public static bool MenuRegion()
    {
        Console.WriteLine("1. Show All Data Region");
        Console.WriteLine("2. Get Region By Id");
        Console.WriteLine("3. Insert Region");
        Console.WriteLine("4. Update Region");
        Console.WriteLine("5. Delete Region");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var region = new Region();

        switch (input)
        {
            case "1":
                var regions = region.GetAll();
                GeneralMenu.List(regions, "regions");
                return true;
            case "2":
                Console.WriteLine("Enter Region Id : ");
                int RegionId = Convert.ToInt32(Console.ReadLine());
                Region result = region.GetById(RegionId);
                int id = result.Id;
                string name = result.Name;
                Console.WriteLine($"Id: {id}, Name: {name}");
                break;
            case "3":
                Console.WriteLine("Enter Region Name to Insert : ");
                string RegionNameInsert = Console.ReadLine();
                var insertResult = region.Insert(RegionNameInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralMenu.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Region Id to Update : ");
                int RegionIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Region Name to Update : ");
                string RegionNameUpdate = Console.ReadLine();
                var updateResult = region.Update(RegionIdUpdate, RegionNameUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Region Id to Delete: ");
                int RegionIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = region.Delete(RegionIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
        Console.WriteLine("1. Show All Data Country");
        Console.WriteLine("2. Get Country By Id");
        Console.WriteLine("3. Insert Country");
        Console.WriteLine("4. Update Country");
        Console.WriteLine("5. Delete Country");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var country = new Country();

        switch (input)
        {
            case "1":
                var countries = country.GetAll();
                GeneralMenu.List(countries, "countries");
                return true;
            case "2":
                Console.WriteLine("Enter Country Id : ");
                string CountryId = Console.ReadLine();
                Country result = country.GetById(CountryId);
                string id = result.Id;
                string name = result.Name;
                int region_id = result.RegionId;
                Console.WriteLine($"Id: {id}, Name: {name}, Region Id : {region_id}");
                break;
            case "3":
                Console.WriteLine("Enter Country Id to Insert : ");
                string CountryIdInsert = Console.ReadLine();
                Console.WriteLine("Enter Country Name to Insert : ");
                string CountryNameInsert = Console.ReadLine();
                Console.WriteLine("Enter Region Id to Insert : ");
                int CountryRegionIdInsert = Convert.ToInt32(Console.ReadLine());
                var insertResult = country.Insert(CountryIdInsert, CountryNameInsert, CountryRegionIdInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralMenu.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Country Id to Update : ");
                string CountryIdUpdate = Console.ReadLine();
                Console.WriteLine("Enter Country Name to Update : ");
                string CountryNameUpdate = Console.ReadLine();
                Console.WriteLine("Enter Region Id to Update : ");
                int CountryRegionIdUpdate = Convert.ToInt32(Console.ReadLine());
                var updateResult = country.Update(CountryIdUpdate, CountryNameUpdate, CountryRegionIdUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Country Id to Delete : ");
                string CountryIdDelete = Console.ReadLine();
                var deleteResult = country.Delete(CountryIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
        Console.WriteLine("1. Show All Data Location");
        Console.WriteLine("2. Get Location By Id");
        Console.WriteLine("3. Insert Location");
        Console.WriteLine("4. Update Location");
        Console.WriteLine("5. Delete Location");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        var input = Console.ReadLine();
        var location = new Location();

        switch (input)
        {
            case "1":
                var locations = location.GetAll();
                GeneralMenu.List(locations, "locations");
                return true;
            case "2":
                Console.WriteLine("Enter Location Id : ");
                int LocationId = Convert.ToInt32(Console.ReadLine());
                Location result = location.GetById(LocationId);
                int id = result.Id;
                string street_address = result.StreetAddress;
                string postal_code = result.PostalCode;
                string city = result.City;
                string state_province = result.StateProvince;
                string country_id = result.CountryId;
                Console.WriteLine($"Id: {id}, Street Address: {street_address}, Postal Code : {postal_code}, City : {city}, State Province : {state_province}, Country Id : {country_id}");
                break;
            case "3":
                Console.WriteLine("Enter Location Id to Insert : ");
                int LocationIdInsert = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Street Address to Insert : ");
                string LocationStreetInsert = Console.ReadLine();
                Console.WriteLine("Enter Postal Code to Insert : ");
                string LocationPostalCodeInsert = Console.ReadLine();
                Console.WriteLine("Enter City to Insert : ");
                string LocationCityInsert = Console.ReadLine();
                Console.WriteLine("Enter State Province to Insert : ");
                string LocationProvinceInsert = Console.ReadLine();
                Console.WriteLine("Enter Country Id to Insert : ");
                string LocationCountryIdInsert = Console.ReadLine();
                var insertResult = location.Insert(LocationIdInsert, LocationStreetInsert, LocationPostalCodeInsert, LocationCityInsert, LocationProvinceInsert, LocationCountryIdInsert);
                int.TryParse(insertResult, out int resultInsert);
                GeneralMenu.PerformInsert(resultInsert);
                break;
            case "4":
                Console.WriteLine("Enter Location Id to Update : ");
                int LocationIdUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Street Address to Update : ");
                string LocationStreetUpdate = Console.ReadLine();
                Console.WriteLine("Enter Postal Code to Update : ");
                string LocationPostalCodeUpdate = Console.ReadLine();
                Console.WriteLine("Enter City to Update : ");
                string LocationCityUpdate = Console.ReadLine();
                Console.WriteLine("Enter State Province to Update : ");
                string LocationProvinceUpdate = Console.ReadLine();
                Console.WriteLine("Enter Country Id to Update : ");
                string LocationCountryIdUpdate = Console.ReadLine();
                var updateResult = location.Update(LocationIdUpdate, LocationStreetUpdate, LocationPostalCodeUpdate, LocationCityUpdate, LocationProvinceUpdate, LocationCountryIdUpdate);
                int.TryParse(updateResult, out int resultUpdate);
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Location Id to Delete : ");
                int LocationIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = location.Delete(LocationIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
                GeneralMenu.List(jobs, "jobs");
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
                GeneralMenu.PerformInsert(resultInsert);
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
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Job Id to Delete : ");
                string JobIdDelete = Console.ReadLine();
                var deleteResult = job.Delete(JobIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
                GeneralMenu.List(departments, "departments");
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
                GeneralMenu.PerformInsert(resultInsert);
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
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Department Id to Delete : ");
                int DepartmentIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = department.Delete(DepartmentIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
                GeneralMenu.List(employees, "employees");
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
                GeneralMenu.PerformInsert(resultInsert);
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
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Employee Id to Delete : ");
                int EmployeeIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = employee.Delete(EmployeeIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
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
                GeneralMenu.List(histories, "histories");
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
                GeneralMenu.PerformInsert(resultInsert);
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
                GeneralMenu.PerformUpdate(resultUpdate);
                break;
            case "5":
                Console.WriteLine("Enter Employee Id to Delete : ");
                int HistoryEmployeeIdDelete = Convert.ToInt32(Console.ReadLine());
                var deleteResult = history.Delete(HistoryEmployeeIdDelete);
                int.TryParse(deleteResult, out int resultDelete);
                GeneralMenu.PerformDelete(resultDelete);
                break;
            case "6":
                return false;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        return true;
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
                MenuRegion();
                break;
            case "2":
                MenuCountry();
                break;
            case "3":
                MenuLocation();
                break;
            case "4":
                MenuJob();
                break;
            case "5":
                MenuDepartment();
                break;
            case "6":
                MenuEmployee();
                break;
            case "7":
                MenuHistory();
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
                GeneralMenu.List(resultJoinA, "Data A");
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
                GeneralMenu.List(resultJoinB, "Data B");
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
    }
}