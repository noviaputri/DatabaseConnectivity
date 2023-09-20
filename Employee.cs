namespace BasicConnectivity;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public int Salary { get; set; }
    public decimal ComissionPct { get; set; }
    public int ManagerId { get; set; }
    public string JobId { get; set; }
    public int DepartmentId { get; set; }

    public override string ToString()
    {
        return $"{Id} - {FirstName} - {LastName} - {Email} - {PhoneNumber} - {HireDate} - {Salary} - {ComissionPct} - {ManagerId} - {JobId} - {DepartmentId}";
    }

    // GET ALL: Employee
    public List<Employee> GetAll()
    {
        var employees = new List<Employee>();

        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM employees";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employees.Add(new Employee
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Email = reader.GetString(3),
                        PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                        HireDate = reader.GetDateTime(5),
                        Salary = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        ComissionPct = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7),
                        ManagerId = reader.GetInt32(8),
                        JobId = reader.GetString(9),
                        DepartmentId = reader.GetInt32(10)
                    });
                }
                reader.Close();
                connection.Close();

                return employees;
            }
            reader.Close();
            connection.Close();

            return new List<Employee>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<Employee>();
    }

    // GET BY ID: Employee
    public Employee GetById(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM employees WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Employee employee = new Employee();

                while (reader.Read())
                {
                    employee.Id = reader.GetInt32(0);
                    employee.FirstName = reader.GetString(1);
                    employee.LastName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    employee.Email = reader.GetString(3);
                    employee.PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4);
                    employee.HireDate = reader.GetDateTime(5);
                    employee.Salary = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                    employee.ComissionPct = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
                    employee.ManagerId = reader.GetInt32(8);
                    employee.JobId = reader.GetString(9);
                    employee.DepartmentId = reader.GetInt32(10);
                }
                reader.Close();
                connection.Close();
                return employee;
            }
            else
            {
                Console.WriteLine("No rows found.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    // INSERT: Employee
    public string Insert(int id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, int salary, decimal comission_pct , int manager_id, string job_id, int department_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO employees (id, first_name, last_name, email, phone_number, hire_date, salary, comission_pct, manager_id, job_id, department_id) VALUES (@id, @first_name, @last_name, @email, @phone_number , @hire_date , @salary , @comission_pct, @manager_id , @job_id , @department_id);";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("first_name", first_name));
            command.Parameters.Add(Provider.SetParameter("last_name", last_name));
            command.Parameters.Add(Provider.SetParameter("email", email));
            command.Parameters.Add(Provider.SetParameter("phone_number", phone_number));
            command.Parameters.Add(Provider.SetParameter("hire_date", hire_date));
            command.Parameters.Add(Provider.SetParameter("salary", salary));
            command.Parameters.Add(Provider.SetParameter("comission_pct", comission_pct));
            command.Parameters.Add(Provider.SetParameter("manager_id", manager_id));
            command.Parameters.Add(Provider.SetParameter("job_id", job_id));
            command.Parameters.Add(Provider.SetParameter("department_id", department_id));

            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                command.Transaction = transaction;

                var result = command.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                return result.ToString();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return $"Error Transaction: {ex.Message}";
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    // UPDATE: Employee
    public string Update(int id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, int salary, decimal comission_pct, int manager_id, string job_id, int department_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE employees SET first_name = @first_name, last_name = @last_name, email = @email, phone_number = @phone_number, hire_date = @hire_date, salary = @salary, comission_pct = @comission_pct, manager_id = @manager_id, job_id = @job_id, department_id = @department_id WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("first_name", first_name));
            command.Parameters.Add(Provider.SetParameter("last_name", last_name));
            command.Parameters.Add(Provider.SetParameter("email", email));
            command.Parameters.Add(Provider.SetParameter("phone_number", phone_number));
            command.Parameters.Add(Provider.SetParameter("hire_date", hire_date));
            command.Parameters.Add(Provider.SetParameter("salary", salary));
            command.Parameters.Add(Provider.SetParameter("comission_pct", comission_pct));
            command.Parameters.Add(Provider.SetParameter("manager_id", manager_id));
            command.Parameters.Add(Provider.SetParameter("job_id", job_id));
            command.Parameters.Add(Provider.SetParameter("department_id", department_id));

            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                command.Transaction = transaction;

                var result = command.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                return result.ToString();
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an exception occurs and print an error message
                transaction.Rollback();
                return $"Error Transaction: {ex.Message}";
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    // DELETE: Employee
    public string Delete(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "DELETE FROM employees WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                command.Transaction = transaction;

                var result = command.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                return result.ToString();
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an exception occurs and print an error message
                transaction.Rollback();
                return $"Error Transaction: {ex.Message}";
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}