namespace BasicConnectivity;

public class Program
{
    public static bool MenuGetAll(string input)
    {
        switch (input)
        {
            case "1":
                var region = new Region();
                var regions = region.GetAll();
                GeneralMenu.List(regions, "regions");
                break;
            case "2":
                var country = new Country();
                var countries = country.GetAll();
                GeneralMenu.List(countries, "countries");
                break;
            case "3":
                var location = new Location();
                var locations = location.GetAll();
                GeneralMenu.List(locations, "locations");
                break;
            case "4":
                var job = new Job();
                var jobs = job.GetAll();
                GeneralMenu.List(jobs, "jobs");
                break;
            case "5":
                var department = new Department();
                var departments = department.GetAll();
                GeneralMenu.List(departments, "departments");
                break;
            case "6":
                var employee = new Employee();
                var employees = employee.GetAll();
                GeneralMenu.List(employees, "employees");
                break;
            case "7":
                var history = new History();
                var histories = history.GetAll();
                GeneralMenu.List(histories, "histories");
                break;
            case "8":
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
            Console.WriteLine("1. List all regions");
            Console.WriteLine("2. List all countries");
            Console.WriteLine("3. List all locations");
            Console.WriteLine("4. List all jobs");
            Console.WriteLine("5. List all departments");
            Console.WriteLine("6. List all employees");
            Console.WriteLine("7. List all histories");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            var input = Console.ReadLine();
            choice = MenuGetAll(input);
        }

        //var region = new Region();
        //var country = new Country();
        //var location = new Location();
        //var job = new Job();
        //var department = new Department();
        //var employee = new Employee();
        //var history = new History();

        // REGION
        /*
        // GetAllRegion
        var getAllRegion = region.GetAll();
        if (getAllRegion.Count > 0)
        {
            foreach (var region1 in getAllRegion)
            {
                Console.WriteLine($"Id: {region1.Id}, Name: {region1.Name}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }

        
        // GetRegionById
        Region result = region.GetById(26);
        // Access the properties of the returned Region object
        int id = result.Id;
        string name = result.Name;
        // Use the retrieved data as needed
        Console.WriteLine($"Id: {id}, Name: {name}");
        */

        /*
        // Insert Region
        var insertResult = region.Insert("Sumatera Barat");
        int.TryParse(insertResult, out int resultInsert);
        if (resultInsert > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else 
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/
        /*
        // Update Region
        var updateResult = region.Update(27,"Sumatera Selatan");
        int.TryParse(updateResult, out int resultUpdate);
        if (resultUpdate > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }
        */

        // Delete Region
        /*
        var deleteResult = region.Delete(26);
        int.TryParse(deleteResult, out int resultDelete);
        if (resultDelete > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/


        // COUNTRY
        /*
        var getAllCountry = country.GetAll();
        if (getAllCountry.Count > 0)
        {
            foreach (var country1 in getAllCountry)
            {
                Console.WriteLine($"Id: {country1.Id}, Name: {country1.Name}, Region Id : {country1.RegionId}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        Country result = country.GetById("AU");
        string id = result.Id;
        string name = result.Name;
        int region_id = result.RegionId;
        Console.WriteLine($"Id: {id}, Name: {name}, Region Id : {region_id}");
        */

        /*
        var insertResult = country.Insert("PN","Papua Nugini",6);
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = country.Update("PN", "Papua N",6);
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = country.Delete("PN");
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

        // LOCATION
        /*
        var getAllLocation = location.GetAll();
        if (getAllLocation.Count > 0)
        {
            foreach (var location1 in getAllLocation)
            {
                Console.WriteLine($"Id: {location1.Id}, Street Address : {location1.StreetAddress}, Postal Code : {location1.PostalCode}, City : {location1.City}, State Province : {location1.StateProvince}, Country Id : {location1.CountryId}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        Location result = location.GetById(11);
        int id = result.Id;
        string street_address = result.StreetAddress;
        string postal_code = result.PostalCode;
        string city = result.City;
        string state_province = result.StateProvince;
        string country_id = result.CountryId;
        Console.WriteLine($"Id: {id}, Street Address: {street_address}, Postal Code : {postal_code}, City : {city}, State Province : {state_province}, Country Id : {country_id}");
        */

        /*
        var insertResult = location.Insert(25,"Jalan Pemuda","100213","Jakarta","DKI Jakarta","ID");
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = location.Update(25, "Jalan Pemuda 5", "100213", "Jakarta", "DKI Jakarta", "ID");
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = location.Delete(25);
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

        // JOB

        /*
        var getAllJob = job.GetAll();
        if (getAllJob.Count > 0)
        {
            foreach (var job1 in getAllJob)
            {
                Console.WriteLine($"Id: {job1.Id}, Title : {job1.Title}, Min Salary : {job1.MinSalary}, Max Salary : {job1.MaxSalary}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        Job result = job.GetById("AD");
        string id = result.Id;
        string title = result.Title;
        int min_salary = result.MinSalary;
        int max_salary = result.MaxSalary;
        Console.WriteLine($"Id: {id}, Title : {title}, Min Salary : {min_salary}, Max Salary : {max_salary}");
        */

        /*
        var insertResult = job.Insert("MT","Management Trainee",10000,15000);
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = job.Update("MT","Management Trainee",9000,13000);
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = job.Delete("MT");
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

        // DEPARTMENT

        /*
        var getAllDepartment = department.GetAll();
        if (getAllDepartment.Count > 0)
        {
            foreach (var department1 in getAllDepartment)
            {
                Console.WriteLine($"Id: {department1.Id}, Name : {department1.Name}, Location Id : {department1.LocationId}, Manager Id : {department1.ManagerId}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        Department result = department.GetById(101);
        int id = result.Id;
        string name = result.Name;
        int location_id = result.LocationId;
        int manager_id = result.ManagerId;
        Console.WriteLine($"Id: {id}, Name : {name}, Location Id : {location_id}, Manager Id : {manager_id}");
        */

        /*
        var insertResult = department.Insert(130,"Management Program",10,1000);
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = department.Update(130, "Management Programming", 10, 1000);
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = department.Delete(130);
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

        // EMPLOYEE

        /*
        var getAllEmployee = employee.GetAll();
        if (getAllEmployee.Count > 0)
        {
            foreach (var employee1 in getAllEmployee)
            {
                Console.WriteLine($"Id: {employee1.Id}, First Name : {employee1.FirstName}, Last Name : {employee1.LastName}, " +
                    $"Email : {employee1.Email}, Phone Number : {employee1.PhoneNumber}, Hire Date : {employee1.HireDate}, Salary : {employee1.Salary}," +
                    $"Comission PCT : {employee1.ComissionPct}, Manager Id : {employee1.ManagerId}, Job Id : {employee1.JobId}, Department Id : {employee1.DepartmentId}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        Employee result = employee.GetById(1000);
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
        */

        /*
        var insertResult = employee.Insert(1050,"Ana","Mariana","anamariana@gmail.com","021938672384", DateTime.Parse("2019-10-10"), 10000,10,1050,"MM",105);
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = employee.Update(1050, "Anna", "Maria", "annamaria@gmail.com", "021938672384", DateTime.Parse("2019-10-10"), 10000, 10, 1050, "MM", 105);
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = employee.Delete(1050);
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

        // HISTORY

        /*
        var getAllHistory = history.GetAll();
        if (getAllHistory.Count > 0)
        {
            foreach (var history1 in getAllHistory)
            {
                Console.WriteLine($"Start Date : {history1.StartDate}, Employee Id : {history1.EmployeeId}, End Date : {history1.EndDate}, " +
                    $"Department Id : {history1.DepartmentId}, Job Id : {history1.JobId}");
            }
        }
        else
        {
            Console.WriteLine("No data found");
        }*/

        /*
        History result = history.GetById(1000);
        DateTime start_date = result.StartDate;
        int employee_id = result.EmployeeId;
        DateTime end_date = result.EndDate;
        int department_id = result.DepartmentId;
        string job_id = result.JobId;
        Console.WriteLine($"Start Date : {start_date}, Employee Id : {employee_id}, End Date : {end_date}, " +
                    $"Department Id : {department_id}, Job Id : {job_id}");
        */

        /*
        var insertResult = history.Insert(DateTime.Parse("2010-11-09"),1060, DateTime.Parse("2015-09-09"),100,"MM");
        int.TryParse(insertResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(insertResult);
        }*/

        /*
        var updateResult = history.Update(1060, DateTime.Parse("2016-09-09"), 100, "MM");
        int.TryParse(updateResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(updateResult);
        }*/

        /*
        var deleteResult = history.Delete(1060);
        int.TryParse(deleteResult, out int result);
        if (result > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(deleteResult);
        }*/

    }
}
