using System.Text.RegularExpressions;

namespace CountdownTimer.Domains;

public partial class TimerUtils
{
    [GeneratedRegex("^([0-1][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$")]
    private static partial Regex MyRegex();

    public static void TimerMenus()
    {
        while (true)
        {
            Menu();
            Console.Write("Enter an option: ");
            var option = Console.ReadLine()!;

            if (option.Equals("0"))
                break;

            if (!option.Equals("1"))
            {
                Console.WriteLine("Invalid option...");
                continue;
            }

            Console.Write("\nEnter a timer from countdown (hh:mm:ss): ");
            var timer = Console.ReadLine()!;

            var decrement = TimeSpan.FromSeconds(1);

            if (MyRegex().IsMatch(timer))
            {
                var timeInput = TimeSpan.Parse(timer);

                for (var rest = timeInput; rest >= TimeSpan.Zero; rest = rest.Subtract(decrement))
                {
                    Console.Clear();
                    Console.Write(rest);
                    Thread.Sleep(decrement);
                }

                Console.WriteLine("Timer finish!!");
            }
            else
                Console.WriteLine("Invalid format for timer, please enter the right pattern (hh:mm:ss).");
        }
    }

    private static void Menu()
    {
        Console.WriteLine($"\n=== Countdown timer ===\n" +
                          $"  1 - Choice the timer\n" +
                          $"  0 - Exit\n" +
                          $"=======================\n");
    }
}