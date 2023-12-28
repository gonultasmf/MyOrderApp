namespace MyOrderApp.Views;

public partial class BasketPage : BasePage<BasketPageViewModel>
{
    public BasketPage(BasketPageViewModel viewModel) : base(viewModel, "Sepet")
    {
    }

    public override void Build()
    {
        this
            .Content(
                new VerticalStackLayout()
                    .Children(new Label()
                        .Text("Basket Page"))
                    .Center()
            );
    }
}
