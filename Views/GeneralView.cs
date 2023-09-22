namespace DatabaseConnectivity;

public class GeneralView
{
    public void List<T>(List<T> items, string title)
    {
        Console.WriteLine($"List of {title}");
        Console.WriteLine("---------------------");
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void Single<T>(T item, string title)
    {
        Console.WriteLine($"List of {title}");
        Console.WriteLine("---------------");
        Console.WriteLine(item.ToString());
    }

    public void PerformInsert(int resultInsert)
    {
        if (resultInsert > 0)
        {
            Console.WriteLine("Insert Success");
        }
        else
        {
            Console.WriteLine("Insert Failed");
            Console.WriteLine(resultInsert);
        }
    }

    public void PerformUpdate(int resultUpdate)
    {
        if (resultUpdate > 0)
        {
            Console.WriteLine("Update Success");
        }
        else
        {
            Console.WriteLine("Update Failed");
            Console.WriteLine(resultUpdate);
        }
    }

    public void PerformDelete(int resultDelete)
    {
        if (resultDelete > 0)
        {
            Console.WriteLine("Delete Success");
        }
        else
        {
            Console.WriteLine("Delete Failed");
            Console.WriteLine(resultDelete);
        }
    }

    public void Transaction(string result)
    {
        int.TryParse(result, out int res);
        if (res > 0)
        {
            Console.WriteLine("Transaction completed successfully");
        }
        else
        {
            Console.WriteLine("Transaction failed");
            Console.WriteLine(result);
        }
    }
}