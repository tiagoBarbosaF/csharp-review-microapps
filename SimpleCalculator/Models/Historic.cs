namespace SimpleCalculator.Models;

public class Historic
{
    public static Dictionary<string, decimal> DictionaryHistoric = new();
    public static Dictionary<string, int> HistoricOperations = new();

    public static string GetHistoric()
    {
        var historicOperation = string.Join("", HistoricOperations.Select(item => item.Key).ToList());
        var historicValues = string
            .Join(", ", DictionaryHistoric.Select(item => item.Value.ToString("F")).ToList());
        DictionaryHistoric.Clear();
        HistoricOperations.Clear();
        return $"{historicOperation}: {historicValues}";
    }
}