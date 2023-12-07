using CountdownTimer.Domains;

namespace CountdownTimer.Main;

public class Main
{
    public static async Task Start()
    {
        await TimerUtils.TimerMenus();
    }
}