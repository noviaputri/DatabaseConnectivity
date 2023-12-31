﻿using BasicConnectivity;

namespace DatabaseConnectivity.Models;

public class Job
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Title} - {MinSalary} - {MaxSalary}";
    }

    // GET ALL: Job
    public List<Job> GetAll()
    {
        var jobs = new List<Job>();

        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM jobs";

        try
        {
            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    jobs.Add(new Job
                    {
                        Id = reader.GetString(0),
                        Title = reader.GetString(1),
                        MinSalary = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        MaxSalary = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        //MaxSalary = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3)
                    });
                }
                reader.Close();
                connection.Close();

                return jobs;
            }
            reader.Close();
            connection.Close();

            return new List<Job>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return new List<Job>();
    }

    // GET BY ID: Location
    public Job GetById(string id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "SELECT * FROM jobs WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", id));

            connection.Open();

            using var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Job job = new Job();

                while (reader.Read())
                {
                    job.Id = reader.GetString(0);
                    job.Title = reader.GetString(1);
                    job.MinSalary = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    job.MaxSalary = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                }
                reader.Close();
                connection.Close();
                return job;
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

    // INSERT: Job
    public string Insert(Job job)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "INSERT INTO jobs (id, title, min_salary, max_salary) VALUES (@id, @title, @min_salary, @max_salary);";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", job.Id));
            command.Parameters.Add(Provider.SetParameter("title", job.Title));
            command.Parameters.Add(Provider.SetParameter("min_salary", job.MinSalary));
            command.Parameters.Add(Provider.SetParameter("max_salary", job.MaxSalary));

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

    // UPDATE: Job
    public string Update(Job job)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "UPDATE jobs SET title = @title, min_salary = @min_salary, max_salary = @max_salary WHERE id = @id;";

        try
        {
            command.Parameters.Add(Provider.SetParameter("id", job.Id));
            command.Parameters.Add(Provider.SetParameter("title", job.Title));
            command.Parameters.Add(Provider.SetParameter("min_salary", job.MinSalary));
            command.Parameters.Add(Provider.SetParameter("max_salary", job.MaxSalary));

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

    // DELETE: Job
    public string Delete(string id)
    {
        using var connection = Provider.GetConnection();
        using var command = Provider.GetCommand();

        command.Connection = connection;
        command.CommandText = "DELETE FROM jobs WHERE id = @id;";

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