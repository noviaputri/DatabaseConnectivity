namespace BasicConnectivity;

public class Location
{
    public int Id { get; set; }
    public string StreetAddress { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string CountryId { get; set; }

    public override string ToString()
    {
        return $"{Id} - {StreetAddress} - {PostalCode} - {City} - {StateProvince} - {CountryId}";
    }

    // GET ALL: Location
    public List<Location> GetAll()
    {
        var locations = new List<Location>();

        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM locations";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    locations.Add(new Location
                    {
                        Id = reader.GetInt32(0),
                        StreetAddress = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        PostalCode = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        City = reader.GetString(3),
                        StateProvince = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        CountryId = reader.GetString(5)
                    });
                }
                reader.Close();
                connection.Close();

                return locations;
            }
            reader.Close();
            connection.Close();

            return new List<Location>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<Location>();
    }

    // GET BY ID: Location
    public Location GetById(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM locations WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Location location = new Location();

                while (reader.Read())
                {
                    location.Id = reader.GetInt32(0);
                    location.StreetAddress = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    location.PostalCode = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    location.City = reader.GetString(3);
                    location.StateProvince = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    location.CountryId = reader.GetString(5);
                }
                reader.Close();
                connection.Close();
                return location;
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

    // INSERT: Location
    public string Insert(int id, string street_address, string postal_code, string city, string state_province, string country_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO locations (id, street_address, postal_code, city, state_province, country_id) VALUES (@id, @street_address, @postal_code, @city, @state_province, @country_id);";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("street_address", street_address));
            command.Parameters.Add(Provider.SetParameter("postal_code", postal_code));
            command.Parameters.Add(Provider.SetParameter("city", city));
            command.Parameters.Add(Provider.SetParameter("state_province", state_province));
            command.Parameters.Add(Provider.SetParameter("country_id", country_id));

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

    // UPDATE: Location
    public string Update(int id, string street_address, string postal_code, string city, string state_province, string country_id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE locations SET street_address = @street_address, postal_code = @postal_code, city = @city, state_province = @state_province, country_id = @country_id WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));
            command.Parameters.Add(Provider.SetParameter("street_address", street_address));
            command.Parameters.Add(Provider.SetParameter("postal_code", postal_code));
            command.Parameters.Add(Provider.SetParameter("city", city));
            command.Parameters.Add(Provider.SetParameter("state_province", state_province));
            command.Parameters.Add(Provider.SetParameter("country_id", country_id));

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

    // DELETE: Location
    public string Delete(int id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        // Set the SQL command text to delete rows from the 'regions' table with given id
        command.CommandText = "DELETE FROM locations WHERE id = @id;";

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