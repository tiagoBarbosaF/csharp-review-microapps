using CountdownTimer.Domains;
using DatabaseReview.Models;

public class Main
{
    public static void Start()
    {
        // TimerUtils.TimerMenus();
        var product = new Product()
        {
            Id = 1,
            Name = "Banana",
            Description = "Yellow fruit",
            Value = 5.50m
        };
        
        Console.WriteLine(product);
    }
}