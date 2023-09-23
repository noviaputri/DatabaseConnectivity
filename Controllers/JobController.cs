using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class JobController
{
    private Job _job;
    private JobView _jobView;

    public JobController(Job job, JobView jobView)
    {
        _job = job;
        _jobView = jobView;
    }

    public void GetAll()
    {
        var results = _job.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _jobView.List(results, "jobs");
        }
    }

    public void GetById()
    {
        var input = _jobView.GetByIdInput();
        var result = _job.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _jobView.Single(result, "job");
        }
    }

    public void Insert()
    {
        var job = new Job();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                job = _jobView.InsertInput();
                if (job.Id == null)
                {
                    Console.WriteLine("Job Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _job.Insert(job);
        _jobView.Transaction(result);
    }

    public void Update()
    {
        var job = new Job();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                job = _jobView.UpdateInput();
                if (job.Id == null)
                {
                    Console.WriteLine("Job Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _job.Update(job);
        _jobView.Transaction(result);
    }

    public void Delete()
    {
        string input = _jobView.DeleteInput();
        var result = _job.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _jobView.Transaction(result);
        }
    }
}
