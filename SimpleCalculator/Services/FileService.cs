namespace SimpleCalculator.Services;

public class FileService
{
    private const string Path = @"HistoricCalculator.txt";

    private static Dictionary<KeyValuePair<int, string>, string> MapFileToDictionary(string line)
    {
        var dictionary = new Dictionary<KeyValuePair<int, string>, string>();
        var elements = line.Split(',');
        var key1 = Convert.ToInt32(elements[0].Trim().Replace("[[", ""));
        var key2 = elements[1].Trim().Replace("]", "");
        var value = string.Join(", ", elements, 2, elements.Length - 2).Trim().Replace("]", "");
        var keyValuePair = new KeyValuePair<int, string>(key1, key2);

        dictionary.Add(keyValuePair, value);

        return dictionary;
    }

    public static void GetHistoricFromFile()
    {
        var listDictionary = new List<Dictionary<KeyValuePair<int, string>, string>>();
        if (listDictionary == null) throw new ArgumentNullException(nameof(listDictionary));

        using (var streamReader = new StreamReader(Path))
        {
            while (!streamReader.EndOfStream)
            {
                var readLine = streamReader.ReadLine();
                if (!string.IsNullOrEmpty(readLine))
                {
                    var mapFileToDictionary = MapFileToDictionary(readLine);
                    listDictionary.Add(mapFileToDictionary);
                }
            }
        }

        foreach (var dictionary in listDictionary)
            dictionary
                .Select(item 
                    => $"{item.Key.Value}:\n{item.Value}")
                .ToList()
                .ForEach(Console.WriteLine);
    }

    public static bool CheckHistoricFileContainsContent() => new FileInfo(Path).Length == 0;

    public static void InitializeFile()
    {
        if (!File.Exists(Path)) File.WriteAllText(Path, string.Empty);
    }

    public static void AddContent(string content) => File.AppendAllText(Path, content + Environment.NewLine);

    public static void ClearFileContent() => File.WriteAllText(Path, string.Empty);
}