namespace BasicConnectivity;

public class Region
{
    // The Id property of the Region class
    public int Id { get; set; }
    // The Name property of the Region class
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }

    // GET ALL: Region
    public List<Region> GetAll()
    {
        var regions = new List<Region>();

        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        // Set the connection property of the command object to the SqlConnection object
        command.Connection = connection;
        // Set the command text to select all rows from the 'regions' table
        command.CommandText = "SELECT * FROM regions";

        try
        {
            // Open the database connection
            connection.Open();
            // Execute the SQL query and retrieve a SqlDataReader object
            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Create a new Region object and populate its properties with data from the SqlDataReader object
                    regions.Add(new Region
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                reader.Close();
                connection.Close();

                return regions;
            }
            reader.Close();
            connection.Close();

            return new List<Region>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return new List<Region>();
    }

    // GET BY ID: Region
    public Region GetById(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        // Set the SQL command text to select rows from the 'regions' table with given id
        command.CommandText = "SELECT * FROM regions WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Region region = new Region();

                while (reader.Read())
                {
                    region.Id = reader.GetInt32(0);
                    region.Name = reader.GetString(1);
                }
                reader.Close();
                connection.Close();
                return region;
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

    // INSERT: Region
    public string Insert(string name)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        // Set the SQL command text to insert data in the 'regions' table with given name
        command.CommandText = "INSERT INTO regions VALUES (@name);";

        try
        {
            command.Parameters.Add(Provider.SetParameter("name", name));

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

    // UPDATE: Region
    public string Update(int id, string name)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        // Set the SQL command text to update the 'name' column in the 'regions' table with given id
        command.CommandText = "UPDATE regions SET name = @name WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("name", name));

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

    // DELETE: Region
    public string Delete(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        // Set the SQL command text to delete rows from the 'regions' table with given id
        command.CommandText = "DELETE FROM regions WHERE id = @id;";

        try
        {
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