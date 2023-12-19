using SimpleCalculator.Models.Interfaces;

namespace SimpleCalculator.Models;

public class Sum : IOperation
{
    public decimal Operation(Dictionary<string, decimal> valueOptions) => valueOptions.Sum(key => key.Value);
}