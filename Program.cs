// Pavan Gajjar
// OOP - Dependency Injection
using System.Text.Json;
using OOP.Helper;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        (new Execution()).checkDependencyInjection();
    }
}

class Execution
{
    public void classVsInterface()
    {
        IEmployee employee = new Employee();
        IEmployee employee1 = new Employee();

        List<IEmployee> employees = new List<IEmployee>();
        employees.Add(employee);
        employees.Add(employee1);

        Console.WriteLine(JsonSerializer.Serialize(employees.ToList()));
    }

    public void checkDependencyInjection()
    {
        Home home = new Home();
        Person person = new Person(home);
        person.TakeRefugee();

        person.School = new School();
        person.Study();

        person.GetTreatment(new Hospital());
    }

    public void checkDependencyInjectionServices()
    {
        Scope scope1 = new Scope();
        Scope scope2 = new Scope();

        Service sample1a = scope1.TransientProvider.GetSample();
        Service sample1b = scope1.TransientProvider.GetSample();
        Service sample2a = scope2.TransientProvider.GetSample();
        Service sample2b = scope2.TransientProvider.GetSample();

        Console.WriteLine(sample1a.Id);
        Console.WriteLine(sample1b.Id);
        Console.WriteLine(sample2a.Id);
        Console.WriteLine(sample2b.Id);
    }

    public void extensionMethod()
    {
        List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        ints.ExtensionMethod();
        ExtensionHelper.ExtensionMethodWithParams(1);
        ints.ExtensionMethodWithParamsAndExtension(1);
    }

    public void tryParsingTechniques()
    {
        try
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out int i))
            {
                Console.WriteLine($"Parsed number {i}");
            }
            else
            {
                Console.WriteLine("Parsing Issue");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine($"Pased Error : {e.Message}");
        }
    }

    public void fibonacciSeries()
    {
        int number = 2;  // Start from index 2 because we will initialize the first two values
        int[] array = new int[50];  // Create an array large enough to hold 100 Fibonacci numbers

        // Initialize the first two numbers in the Fibonacci sequence
        array[0] = 0;
        array[1] = 1;
        while (number < 50)
        {

            array[number] = array[number - 1] + array[number - 2];
                number++;
        }
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}