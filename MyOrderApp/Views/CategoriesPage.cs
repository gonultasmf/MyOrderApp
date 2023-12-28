namespace MyOrderApp.Views;

public partial class CategoriesPage : BasePage<CategoriesPageViewModel>
{
    public CategoriesPage(CategoriesPageViewModel viewModel) : base(viewModel, "Kategoriler")
    {
    }

    public override void Build()
    {
        this
            .Content(
                new VerticalStackLayout()
                    .Children(new Label()
                        .Text("Categories Page"))
                    .Center()
            );
    }
}
