namespace BasicConnectivity;

public class GeneralMenu
{
    public static void List<T>(List<T> items, string title)
    {
        Console.WriteLine($"List of {title}");
        Console.WriteLine("---------------------");
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void PerformInsert(int resultInsert)
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

    public static void PerformUpdate(int resultUpdate)
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

    public static void PerformDelete(int resultDelete)
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
}