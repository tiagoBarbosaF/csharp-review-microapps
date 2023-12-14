using System.Text.RegularExpressions;
using SimpleCalculator.Models.Enums;

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
                          $"\t      {(int)OperationTypes.Sum} - {OperationTypes.Sum}\n" +
                          $"\t      {(int)OperationTypes.Subtraction} - {OperationTypes.Subtraction}\n" +
                          $"\t      {(int)OperationTypes.Multiply} - {OperationTypes.Multiply}\n" +
                          $"\t      {(int)OperationTypes.Division} - {OperationTypes.Division}\n" +
                          $"\t      {(int)OperationTypes.Mod} - {OperationTypes.Mod}\n" +
                          $"\t      {(int)OperationTypes.SquareRoot} - {OperationTypes.SquareRoot}\n" +
                          $"\t      {(int)OperationTypes.Historic} - {OperationTypes.Historic}\n" +
                          $"\t      {(int)OperationTypes.Exit} - {OperationTypes.Exit}\n" +
                          $"\t{titleBar}\n\n" +
                          $"{menuBar}");
    }

    public static OperationTypes MenuGetOptions()
    {
        Console.Write($"\nEnter the option: ");
        var option = int.Parse(Console.ReadLine()!);

        if (Enum.IsDefined(typeof(OperationTypes), option))
        {
            return (OperationTypes)option;
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter a valid option.");
            return OperationTypes.Exit;
        }
    }

    public static Dictionary<string, decimal> GetNumberOptions(OperationTypes option)
    {
        var i = (decimal)0;
        var numberOptions = new Dictionary<string, decimal>();
        const string pattern = @"^[0-9]+(\.[0-9]+)?$";

        while (true)
        {
            decimal num;
            if (option is OperationTypes.SquareRoot)
            {
                Console.Write($"Enter the value: ");
                num = decimal.Parse(Console.ReadLine()!);
                numberOptions.Add($"num{++i}", num);
                break;
            }

            Console.Write($"Enter the value (s - exit): ");
            var readOption = Console.ReadLine()!;

            if (readOption.ToLower().Equals("s")) break;

            if (!Regex.IsMatch(readOption, pattern))
            {
                Console.WriteLine("Enter a valid value. For decimal values, use \".\"");
                continue;
            }

            num = decimal.Parse(readOption);
            numberOptions.Add($"num{++i}", num);
            Historic.HistoricOperations[$"{option}"] = (int)option;
            Historic.DictionaryHistoric.Add($"num{++i}", num);
        }

        return numberOptions;
    }
}