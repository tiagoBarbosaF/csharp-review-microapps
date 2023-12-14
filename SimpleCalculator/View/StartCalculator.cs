using SimpleCalculator.Models;
using SimpleCalculator.Models.Enums;

namespace SimpleCalculator.View;

public class StartCalculator
{
    public static void Start()
    {
        while (true)
        {
            MenuOptions.Menu();
            var getOptions = MenuOptions.MenuGetOptions();

            if (getOptions is OperationTypes.Exit) break;

            switch (getOptions)
            {
                case OperationTypes.Sum:
                    var numberOptions = MenuOptions.GetNumberOptions(OperationTypes.Sum);
                    Console.WriteLine($"\nResult: {new Sum().Operation(numberOptions):F}");
                    break;
                case OperationTypes.Subtraction:
                    numberOptions = MenuOptions.GetNumberOptions(OperationTypes.Subtraction);
                    Console.WriteLine($"\nResult: {new Subtraction().Operation(numberOptions):F}");
                    break;
                case OperationTypes.Multiply:
                    numberOptions = MenuOptions.GetNumberOptions(OperationTypes.Multiply);
                    Console.WriteLine($"\nResult: {new Multiply().Operation(numberOptions):F}");
                    break;
                case OperationTypes.Division:
                    numberOptions = MenuOptions.GetNumberOptions(OperationTypes.Division);
                    Console.WriteLine($"\nResult: {new Division().Operation(numberOptions):F}");
                    break;
                case OperationTypes.Mod:
                    numberOptions = MenuOptions.GetNumberOptions(OperationTypes.Mod);
                    Console.WriteLine($"\nResult: {new Mod().Operation(numberOptions):F}");
                    break;
                case OperationTypes.SquareRoot:
                    numberOptions = MenuOptions.GetNumberOptions(OperationTypes.SquareRoot);
                    Console.WriteLine($"\nResult: {new SquareRoot().Operation(numberOptions):F}");
                    break;
                case OperationTypes.Historic:
                    Console.WriteLine($"\n-- Historic --\n{Historic.GetHistoric()}");
                    break;
                default:
                    Console.WriteLine("Invalid operation, choose one of the operations in the Menu...");
                    break;
            }
        }
    }
}