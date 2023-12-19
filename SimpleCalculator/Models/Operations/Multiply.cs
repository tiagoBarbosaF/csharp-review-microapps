using SimpleCalculator.Models.Interfaces;

namespace SimpleCalculator.Models;

public class Multiply : IOperation
{
    public decimal Operation(Dictionary<string, decimal> valueOptions)
    {
        var result = valueOptions.First().Value;
        return valueOptions.Skip(1).Aggregate(result, (current, key) => current * key.Value);
    }
}