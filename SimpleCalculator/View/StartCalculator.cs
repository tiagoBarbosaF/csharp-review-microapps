using SimpleCalculator.Handlers;
using SimpleCalculator.Models;
using SimpleCalculator.Models.Enums;
using SimpleCalculator.Models.Interfaces;

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

            if (getOptions is OperationTypes.Historic)
                if (Historic.CheckHistoricEmpty())
                    Console.WriteLine("\nHistoric Empty!!");
                else
                {
                    Console.WriteLine("\nHistoric:\n");
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