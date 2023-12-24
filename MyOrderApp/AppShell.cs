namespace MyOrderApp;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider services)
    {
        Items.Add(services.GetService<LoadingPage>());
        Items.Add(services.GetService<LoginPage>());
        Items.Add(services.GetService<HomePage>());
        Items.Add(services.GetService<RegisterPage>());
    }
}
