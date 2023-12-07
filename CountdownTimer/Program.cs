// See https://aka.ms/new-console-template for more information

Console.WriteLine("Countdown");

var minutes = TimeSpan.FromMinutes(1);
var timer = TimeSpan.FromSeconds(15);
var interval = TimeSpan.FromSeconds(1);
// Console.WriteLine(minutes);

Console.Clear();
for (var rest = timer; rest > TimeSpan.Zero; rest = rest.Subtract(interval))
{
    Console.WriteLine(rest);
    await Task.Delay(1000);
    Console.Clear();
}