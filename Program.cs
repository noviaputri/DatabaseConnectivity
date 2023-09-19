using System.Data;
using System.Data.SqlClient;

namespace BasicConnectivity;

public class Program
{
    // Define the connection string for the database
    private static readonly string connectionString = "Data Source=LAPTOP-LFKIL3TQ;Integrated Security=True;Database=db_hr_dts;Connect Timeout=30;";

    private static void Main()
    {
        GetAllRegions();
        //InsertRegion("Sulawesi Utara");
        //GetRegionById(10);
        //UpdateRegion(26, "Sulawesi Timur");
        //DeleteRegion(24);
    }

    // GET ALL: Region
    public static void GetAllRegions()
    {
        // Create a connection to the database using the connection string
        using var connection = new SqlConnection(connectionString);
        // Create a new SQL command object
        using var command = new SqlCommand();
        // Set the connection for the command object
        command.Connection = connection;
        // Set the SQL command text to select all rows from the 'regions' table
        command.CommandText = "SELECT * FROM regions";

        try
        {
            // Open the database connection
            connection.Open();
            // Execute the SQL command and retrieve the results
            using var reader = command.ExecuteReader();
            // Check if there are any rows in the result set
            if (reader.HasRows)
                // Iterate over each row in the result set
                while (reader.Read())
                {
                    // Print the value of the 'Id' column for the current row
                    Console.WriteLine("Id: " + reader.GetInt32(0));
                    // Print the value of the 'Name' column for the current row
                    Console.WriteLine("Name: " + reader.GetString(1));
                }
            else
                // Print a message if no rows are found in the result set
                Console.WriteLine("No rows found.");
            // Close the data reader
            reader.Close();
            // Close the database connection
            connection.Close();
        }
        catch (Exception ex)
        {
            // Print an error message if an exception occurs during execution
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // GET BY ID: Region
    public static void GetRegionById(int id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        // Set the SQL command text to select rows from the 'regions' table with given id
        command.CommandText = "SELECT * FROM regions WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.Int;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pId);

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
                while (reader.Read())
                {
                    Console.WriteLine("Id: " + reader.GetInt32(0));
                    Console.WriteLine("Name: " + reader.GetString(1));
                }
            else
                Console.WriteLine("No rows found.");

            reader.Close();
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // INSERT: Region
    public static void InsertRegion(string name)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        // Set the SQL command text to insert a new row into the 'regions' table
        command.CommandText = "INSERT INTO regions VALUES (@name);";

        try
        {
            // Create a new SQL parameter for the 'name' value
            var pName = new SqlParameter();
            pName.ParameterName = "@name";
            pName.Value = name;
            pName.SqlDbType = SqlDbType.VarChar;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pName);

            connection.Open();
            // Begin a new transaction
            using var transaction = connection.BeginTransaction();
            try
            {
                // Set the transaction for the command object
                command.Transaction = transaction;
                // Execute the SQL command and get the number of affected rows
                var result = command.ExecuteNonQuery();
                // Commit the transaction
                transaction.Commit();
                // Close the database connection
                connection.Close();

                // Check the number of affected rows and print a success or failure message
                switch (result)
                {
                    case >= 1:
                        Console.WriteLine("Insert Success");
                        break;
                    default:
                        Console.WriteLine("Insert Failed");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an exception occurs and print an error message
                transaction.Rollback();
                Console.WriteLine($"Error Transaction: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // UPDATE: Region
    public static void UpdateRegion(int id, string name)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        // Set the SQL command text to update the 'name' column in the 'regions' table based on the 'id' value
        command.CommandText = "UPDATE regions SET name = (@name) WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.Int;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pId);

            // Create a new SQL parameter for the 'name' value
            var pName = new SqlParameter();
            pName.ParameterName = "@name";
            pName.Value = name;
            pName.SqlDbType = SqlDbType.VarChar;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pName);

            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                command.Transaction = transaction;

                var result = command.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                switch (result)
                {
                    case >= 1:
                        Console.WriteLine("Update Success");
                        break;
                    default:
                        Console.WriteLine("Update Failed");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an exception occurs and print an error message
                transaction.Rollback();
                Console.WriteLine($"Error Transaction: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // DELETE: Region
    public static void DeleteRegion(int id)
    {
        using var connection = new SqlConnection(connectionString);
        using var command = new SqlCommand();

        command.Connection = connection;
        command.CommandText = "DELETE FROM regions WHERE id = @id;";

        try
        {
            // Create a new SQL parameter for the 'id' value
            var pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.Int;
            // Add the parameter to the command object's parameters collection
            command.Parameters.Add(pId);

            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                command.Transaction = transaction;

                var result = command.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                switch (result)
                {
                    case >= 1:
                        Console.WriteLine("Delete Success");
                        break;
                    default:
                        Console.WriteLine("Delete Failed");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Roll back the transaction if an exception occurs and print an error message
                transaction.Rollback();
                Console.WriteLine($"Error Transaction: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
