namespace MyOrderApp.Views;

public partial class RegisterPage : BasePage<RegisterPageViewModel>
{
    public RegisterPage(RegisterPageViewModel viewModel) : base(viewModel, "Kayıt Sayfası")
    {
    }

    public override void Build()
    {
        Content = new StackLayout()
            .Children(
                new Label()
                .Text("Kayıt Sayfası")
            )
            .Center();
    }
}
