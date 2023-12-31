namespace MyOrderApp.Models;

public class SubCategoryVM
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string IconId { get; set; }
    public ImageSource Icon { get; set; }
}
