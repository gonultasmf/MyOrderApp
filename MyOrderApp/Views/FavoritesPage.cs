namespace MyOrderApp.Views;

public partial class FavoritesPage : BasePage<FavoritesPageViewModel>
{
    public FavoritesPage(FavoritesPageViewModel viewModel) : base(viewModel, "Favoriler")
    {
    }

    public override void Build()
    {
        this
            .Content(
                new VerticalStackLayout()
                    .Children(new Label()
                        .Text("Favorites Page"))
                    .Center()
            );
    }
}
