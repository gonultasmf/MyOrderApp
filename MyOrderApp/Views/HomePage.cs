namespace MyOrderApp.Views;

public partial class HomePage : BasePage<HomePageViewModel>
{
    public HomePage(HomePageViewModel viewModel) : base(viewModel, "Home Page")
    {
    }

    public override void Build()
    {
        Content = new VerticalStackLayout()
            .Children(new Label()
                .Text("Home Page"))
            .Center();
    }
}
