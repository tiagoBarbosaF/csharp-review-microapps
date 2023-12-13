namespace SimpleCalculator.Models;

public class MenuOptions
{
    public static void Menu()
    {
        var menuBar = new string('-', 50);
        const string titleApp = "==== Simple Calculator ====";
        var titleBar = new string('=', titleApp.Length);
        Console.WriteLine($"\n{menuBar}\n\n" +
                          $"\t{titleApp}\n" +
                          $"\t  Choice your operation:\n" +
                          $"\t      1 - Sum\n" +
                          $"\t      2 - Subtraction\n" +
                          $"\t      3 - Multiple\n" +
                          $"\t      4 - Division\n" +
                          $"\t      5 - Mod\n" +
                          $"\t      6 - Square root\n" +
                          $"\t      0 - Exit\n" +
                          $"\t{titleBar}\n\n" +
                          $"{menuBar}");
    }

    public static string MenuGetOptions()
    {
        Console.Write($"\nEnter the option: ");
        return Console.ReadLine()!;
    }
    
    public static Dictionary<string, decimal> GetNumberOptions(string option)
    {
        var i = (decimal)0;
        decimal num;
        var numberOptions = new Dictionary<string, decimal>();

        while (true)
        {
            if (option.Equals("6"))
            {
                Console.Write($"Enter the value: ");
                num = decimal.Parse(Console.ReadLine()!);
                numberOptions.Add($"num{++i}", num);
                break;
            }

            Console.Write($"Enter the value (s - exit): ");
            var readOption = Console.ReadLine()!;

            if (readOption.ToLower().Equals("s")) break;

            num = decimal.Parse(readOption);
            numberOptions.Add($"num{++i}", num);
        }

        return numberOptions;
    }
}