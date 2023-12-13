using SimpleCalculator.Models;

namespace SimpleCalculator.View;

public class StartCalculator
{
    public static void Start()
    {
        while (true)
        {
            MenuOptions.Menu();
            var getOptions = MenuOptions.MenuGetOptions();

            if (getOptions.Equals("0")) break;

            switch (getOptions)
            {
                case "1":
                    var numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new Sum().Operation(numberOptions)}");
                    break;
                case "2":
                    numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new Subtraction().Operation(numberOptions):F}");
                    break;
                case "3":
                    numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new Multiply().Operation(numberOptions):F}");
                    break;
                case "4":
                    numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new Division().Operation(numberOptions):F}");
                    break;
                case "5":
                    numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new Mod().Operation(numberOptions):F}");
                    break;
                case "6":
                    numberOptions = MenuOptions.GetNumberOptions(getOptions);
                    Console.WriteLine($"\nResult: {new SquareRoot().Operation(numberOptions):F}");
                    break;
                default:
                    Console.WriteLine("Invalid operation...");
                    break;
            }
        }
    }
}