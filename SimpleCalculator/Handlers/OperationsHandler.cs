using SimpleCalculator.Models;
using SimpleCalculator.Models.Enums;
using SimpleCalculator.Models.Interfaces;

namespace SimpleCalculator.Handlers;

public class OperationsHandler
{
    private readonly Dictionary<OperationTypes, IOperation> _operationTypes;

    private OperationsHandler()
    {
        _operationTypes = new Dictionary<OperationTypes, IOperation>
        {
            { OperationTypes.Sum, new Sum() },
            { OperationTypes.Subtraction, new Subtraction() },
            { OperationTypes.Multiply, new Multiply() },
            { OperationTypes.Division, new Division() },
            { OperationTypes.Mod, new Mod() },
            { OperationTypes.SquareRoot, new SquareRoot() }
        };
    }

    public static IOperation ExecuteOperations(OperationTypes operationTypes) =>
        new OperationsHandler()._operationTypes[operationTypes];
}