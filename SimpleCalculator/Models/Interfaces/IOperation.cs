namespace SimpleCalculator.Models.Interfaces;

public interface IOperation
{
    decimal Operation(Dictionary<string, decimal> valueOptions);
}