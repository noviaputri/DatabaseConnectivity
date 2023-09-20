using System.Data;
using System.Data.SqlClient;
using static BasicConnectivity.Program;

namespace BasicConnectivity;

public class Country
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int RegionId { get; set; }

    private readonly string connectionString = DatabaseHelper.ConnectionString;

    // GET ALL: Country
    public List<Country> GetAll()
    {
        var countries = new List<Country>();

        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM countries";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        Id = reader.GetString(0),
                        Name = reader.GetString(1),
                        RegionId = reader.GetInt32(2)
                    });
                }
                reader.Close();
                connection.Close();

                return countries;
            }
            reader.Close();
            connection.Close();

            return new List<Country>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<Country>();
    }

    // GET BY ID: Country
    public Country GetById(string id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        // Set the SQL command text to select rows from the 'countries' table with given id
        command.CommandText = "SELECT * FROM countries WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.Char;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pId);

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Country country = new Country();

                while (reader.Read())
                {
                    country.Id = reader.GetString(0);
                    country.Name = reader.GetString(1);
                    country.RegionId = reader.GetInt32(2);
                }
                reader.Close();
                connection.Close();
                return country;
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


    // INSERT: Country
    public string Insert(string id, string name, int region_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO countries (id, name, region_id) VALUES (@id, @name, @region_id);";

        try
        {
            command.Parameters.Add(new SqlParameter("@id", id));
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@region_id", region_id));

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

    // UPDATE: Country
    public string Update(string id, string name, int region_id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE countries SET name = @name, region_id = @region_id WHERE id = @id;";

        try
        {
            command.Parameters.Add(new SqlParameter("@id", id));
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@region_id", region_id));

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

    // DELETE: Country
    public string Delete(string id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        // Set the SQL command text to delete rows from the 'regions' table with given id
        command.CommandText = "DELETE FROM countries WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            command.Parameters.Add(new SqlParameter("@id", id));

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