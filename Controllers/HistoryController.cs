using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;

public class HistoryController
{
    private History _history;
    private HistoryView _historyView;

    public HistoryController(History history, HistoryView historyView)
    {
        _history = history;
        _historyView = historyView;
    }

    public void GetAll()
    {
        var results = _history.GetAll();
        if (!results.Any())
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _historyView.List(results, "histories");
        }
    }

    public void GetById()
    {
        var input = _historyView.GetByIdInput();
        var result = _history.GetById(input);
        if (result == null)
        {
            Console.WriteLine("No data found");
        }
        else
        {
            _historyView.Single(result, "history");
        }
    }

    public void Insert()
    {
        var history = new History();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                history = _historyView.InsertInput();
                if (history.StartDate == null)
                {
                    Console.WriteLine("History Start Date cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _history.Insert(history);
        _historyView.Transaction(result);
    }

    public void Update()
    {
        var history = new History();
        var isTrue = true;
        while (isTrue)
        {
            try
            {
                history = _historyView.UpdateInput();
                if (history.EmployeeId == null)
                {
                    Console.WriteLine("Employee Id cannot be empty");
                    continue;
                }
                isTrue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        var result = _history.Update(history);
        _historyView.Transaction(result);
    }

    public void Delete()
    {
        int input = _historyView.DeleteInput();
        var result = _history.Delete(input);
        if (result == null)
        {
            Console.WriteLine("No data to delete");
        }
        else
        {
            _historyView.Transaction(result);
        }
    }
}
