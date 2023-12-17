using SimpleCalculator.Handlers;
using SimpleCalculator.Models;
using SimpleCalculator.Models.Enums;
using SimpleCalculator.Services;

namespace SimpleCalculator.View;

public class StartCalculator
{
    public static void Start()
    {
        FileService.InitializeFile();

        while (true)
        {
            MenuOptions.Menu();
            var getOptions = MenuOptions.MenuGetOptions();

            if (getOptions is OperationTypes.Exit) break;

            if (getOptions is OperationTypes.Error)
            {
                Console.WriteLine("Enter a valid Option from menu!");
                continue;
            }

            if (getOptions is OperationTypes.Historic)
            {
                Console.WriteLine("\nHistoric:");
                Historic.GetHistoric();
            }
            else if (getOptions is OperationTypes.CleanHistoric)
            {
                Historic.ClearHistoric();
                Console.WriteLine("Historic cleaned!");
            }
            else
            {
                var executeOperations = OperationsHandler.ExecuteOperations(getOptions);
                var resultOperation =
                    executeOperations.Operation(MenuOptions.GetNumberOptions(getOptions)).ToString("F");

                Console.WriteLine($"\nResult: {resultOperation}");
            }
        }
    }
}