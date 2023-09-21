namespace BasicConnectivity;

public class JoinBVM
{
    // Create the attributes of an object of the JoinBVM class
    public string DepartmentName { get; set; }
    public int TotalEmployee { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
    public double AverageSalary { get; set; }

    // Create override ToString() method to returns a string representation of an instance of the JoinBVM class
    public override string ToString()
    {
        return $"{DepartmentName} - {TotalEmployee} - {MinSalary} - {MaxSalary} - {AverageSalary}";
    }
}