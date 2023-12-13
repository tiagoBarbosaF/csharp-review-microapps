using SimpleCalculator.Models.Interfaces;

namespace SimpleCalculator.Models;

public class SquareRoot : IOperation
{
    public decimal Operation(Dictionary<string, decimal> valueOptions)
    {
        var result = (decimal)0;
        foreach (var key in valueOptions) result = (decimal)Math.Sqrt((double)key.Value);

        return result;
    }
}