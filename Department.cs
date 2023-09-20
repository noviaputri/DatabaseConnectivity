namespace BasicConnectivity;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int LocationId { get; set; }
    public int ManagerId { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name} - {LocationId} - {ManagerId}";
    }

    // GET ALL: Department
    public List<Department> GetAll()
    {
        var departments = new List<Department>();

        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM departments";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        LocationId = reader.GetInt32(2),
                        ManagerId = reader.GetInt32(3)
                    });
                }
                reader.Close();
                connection.Close();

                return departments;
            }
            reader.Close();
            connection.Close();

            return new List<Department>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<Department>();
    }

    // GET BY ID: Department
    public Department GetById(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM departments WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Department department = new Department();

                while (reader.Read())
                {
                    department.Id = reader.GetInt32(0);
                    department.Name = reader.GetString(1);
                    department.LocationId = reader.GetInt32(2);
                    department.ManagerId = reader.GetInt32(3);
                }
                reader.Close();
                connection.Close();
                return department;
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

    // INSERT: Department
    public string Insert(int id, string name, int location_id, int manager_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO departments (id, name, location_id, manager_id) VALUES (@id, @name, @location_id, @manager_id);";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("name", name));
            command.Parameters.Add(Provider.SetParameter("location_id", location_id));
            command.Parameters.Add(Provider.SetParameter("manager_id", manager_id));

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

    // UPDATE: Department
    public string Update(int id, string name, int location_id, int manager_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE departments SET name = @name, location_id = @location_id, manager_id = @manager_id WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("name", name));
            command.Parameters.Add(Provider.SetParameter("location_id", location_id));
            command.Parameters.Add(Provider.SetParameter("manager_id", manager_id));

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

    // DELETE: Department
    public string Delete(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "DELETE FROM departments WHERE id = @id;";

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