namespace SimpleCalculator.Models;

public static class Historic
{
    private static readonly Dictionary<KeyValuePair<int, string>, string> HistoricControl = new();

    public static void GetHistoric() => HistoricControl
        .Select(item => $"{item.Key.Value}:\n{item.Value}")
        .ToList()
        .ForEach(Console.WriteLine);

    public static bool CheckHistoricEmpty() => HistoricControl.Count == 0;

    public static void AddHistoric(KeyValuePair<int, string> key, string value) => HistoricControl.Add(key, value);

    public static KeyValuePair<KeyValuePair<int, string>, string> GetLastHistoricKey() => HistoricControl.Last();
    public static void ClearHistoric() => HistoricControl.Clear();
}