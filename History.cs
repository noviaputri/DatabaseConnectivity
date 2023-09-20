using System.Data.SqlClient;
using static BasicConnectivity.Program;

namespace BasicConnectivity;

public class History
{
    public DateTime StartDate { get; set; }
    public int EmployeeId { get; set; }
    public DateTime EndDate { get; set; }
    public int DepartmentId { get; set; }
    public string JobId { get; set; }

    private readonly string connectionString = DatabaseHelper.ConnectionString;

    // GET ALL: History
    public List<History> GetAll()
    {
        var histories = new List<History>();

        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM histories";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    histories.Add(new History
                    {
                        StartDate = reader.GetDateTime(0),
                        EmployeeId = reader.GetInt32(1),
                        EndDate = reader.IsDBNull(2) ? DateTime.Parse("1000-01-01") : reader.GetDateTime(2),
                        //EndDate = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                        DepartmentId = reader.GetInt32(3),
                        JobId = reader.GetString(4)
                    });
                }
                reader.Close();
                connection.Close();

                return histories;
            }
            reader.Close();
            connection.Close();

            return new List<History>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<History>();
    }

    // GET BY ID: History
    public History GetById(int employee_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM histories WHERE employee_id = @employee_id;";

        try
        {
            command.Parameters.Add(new SqlParameter("@employee_id", employee_id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                History history = new History();

                while (reader.Read())
                {
                    history.StartDate = reader.GetDateTime(0);
                    history.EmployeeId = reader.GetInt32(1);
                    history.EndDate = reader.IsDBNull(2) ? DateTime.Parse("1000-01-01") : reader.GetDateTime(2);
                    history.DepartmentId = reader.GetInt32(3);
                    history.JobId = reader.GetString(4);
                }
                reader.Close();
                connection.Close();
                return history;
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

    // INSERT: History
    public string Insert(DateTime start_date, int employee_id, DateTime end_date, int department_id, string job_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO histories (start_date, employee_id, end_date, department_id, job_id) VALUES (@start_date, @employee_id, @end_date, @department_id, @job_id);";

        try
        {
            command.Parameters.Add(new SqlParameter("@start_date", start_date));
            command.Parameters.Add(new SqlParameter("@employee_id", employee_id));
            command.Parameters.Add(new SqlParameter("@end_date", end_date));
            command.Parameters.Add(new SqlParameter("@department_id", department_id));
            command.Parameters.Add(new SqlParameter("@job_id", job_id));

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

    // UPDATE: History
    public string Update(int employee_id, DateTime end_date, int department_id, string job_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE histories SET end_date = @end_date, department_id = @department_id, job_id = @job_id WHERE employee_id = @employee_id;";

        try
        {
            //command.Parameters.Add(new SqlParameter("@start_date", start_date));
            command.Parameters.Add(new SqlParameter("@employee_id", employee_id));
            command.Parameters.Add(new SqlParameter("@end_date", end_date));
            command.Parameters.Add(new SqlParameter("@department_id", department_id));
            command.Parameters.Add(new SqlParameter("@job_id", job_id));

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

    // DELETE: History
    public string Delete(int employee_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "DELETE FROM histories WHERE employee_id = @employee_id;";

        try
        {
            // Create a new SQL parameter for the 'employee_id' value
            command.Parameters.Add(new SqlParameter("@employee_id", employee_id));

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