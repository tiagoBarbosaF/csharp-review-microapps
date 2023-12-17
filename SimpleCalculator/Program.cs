using System.Reflection.Emit;
using SimpleCalculator.Models;
using SimpleCalculator.Models.Enums;
using SimpleCalculator.View;

StartCalculator.Start();

// var dictionary = new Dictionary<KeyValuePair<int, string>, string>
// {
//     { new KeyValuePair<int, string>((int)OperationTypes.Sum + 1, OperationTypes.Sum.ToString()), "10,10" },
//     { new KeyValuePair<int, string>((int)OperationTypes.Sum + 2, OperationTypes.Sum.ToString()), "20,20" },
//     { new KeyValuePair<int, string>((int)OperationTypes.Subtraction, OperationTypes.Subtraction.ToString()), "100,10" }
// };
//
// foreach (var key in dictionary)
// {
//     Historic.AddHistoric(key.Key, key.Value);
// }

// Historic.GetHistoric();
// Historic.HistoricControl.Select(item=>$"{item}").ToList().ForEach(Console.WriteLine);

// var path = @"fileTest.txt";

// using (var fileStream = File.CreateText(path))
// {
//     // fileStream.WriteLine("Hello");
//     // fileStream.WriteLine("And");
//     // fileStream.WriteLine("Welcome.");
//     foreach (var key in Historic.HistoricControl)
//     {
//         fileStream.WriteLine(key);
//     }
// }

// var listDict = new List<Dictionary<KeyValuePair<int, string>, string>>();
// using (var streamReader = new StreamReader(path))
// {
//     while (!streamReader.EndOfStream)
//     {
//         string? line = streamReader.ReadLine();
//         if (!string.IsNullOrEmpty(line))
//         {
//             var dictionaryMap = MapDict(line);
//             listDict.Add(dictionaryMap);
//         }
//     }
// }
//
// Dictionary<KeyValuePair<int, string>, string> MapDict(string line)
// {
//     Dictionary<KeyValuePair<int, string>, string> test = new Dictionary<KeyValuePair<int, string>, string>();
//     string[] elements = line.Split(',');
//     var key1 = Convert.ToInt32(elements[0].Trim().Replace("[[",""));
//     var key2 = elements[1].Trim().Replace("]", "");
//     var value = string.Join(",", elements, 2, elements.Length - 2).Trim().Replace("]", "");
//     var keyValuePair = new KeyValuePair<int, string>(key1, key2);
//     test.Add(keyValuePair, value);
//
//     return test;
// }
//
// foreach (var key in listDict)
// {
//     key.Select(item=>$"{item}").ToList().ForEach(Console.WriteLine);
// }

// File.WriteAllText(path, string.Empty);
// var length = new FileInfo(path).Length;
// Console.WriteLine(length);