using SimpleCalculator.Models.Interfaces;

namespace SimpleCalculator.Models;

public class Division : IOperation
{
    public decimal Operation(Dictionary<string, decimal> valueOptions)
    {
        var result = valueOptions.First().Value;
        try
        {
            result = valueOptions.Skip(1).Aggregate(result, (current, key) => current / key.Value);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            return 0;
        }

        return result;
    }
}