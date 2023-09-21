namespace BasicConnectivity;

public class JoinAVM
{
    // Create the attributes of an object of the JoinAVM class
    public int EmployeeId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Salary { get; set; }
    public string DepartmentName { get; set; }
    public string StreetAddress { get; set; }
    public string CountryName { get; set; }
    public string RegionName { get; set; }

    // Create override ToString() method to returns a string representation of an instance of the JoinAVM class
    public override string ToString()
    {
        return $"{EmployeeId} - {FullName} - {Email} - {Phone} - {Salary} - {DepartmentName} - {StreetAddress} - {CountryName} - {RegionName}";
    }
}