namespace MyOrderApp;

public partial class App : Application
{
    public static string AuthKey = string.Empty;

    public App(IServiceProvider services)
    {
        MainPage = new AppShell(services)
                        .ShellNavBarIsVisible(false);
    }
}
