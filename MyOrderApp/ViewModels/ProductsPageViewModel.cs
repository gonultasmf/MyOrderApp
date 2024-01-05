using AutoMapper;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class ProductsPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ProductVM> _products;


    private readonly IProductRepository _productRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public ProductsPageViewModel(IProductRepository productRepository, 
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _productRepository = productRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        Products = _mapper.Map<ObservableCollection<ProductVM>>(mapProducts);
    }



    public ICommand SearchCommand => new Command((object val) =>
    {
        var result = mapProducts.Where(x => val != null ? x.Name.Contains(val?.ToString()) : true);
        Products = _mapper.Map<ObservableCollection<ProductVM>>(result);
    });


    public ICommand AddProductBasketCommand => new Command((object parameter) =>
    {

    });


    public ICommand ChangeFavoriteCommand => new Command((object parameter) =>
    {
        var product = (ProductVM)parameter;
        var index = Products.IndexOf(product);
        product.IsFavorite = !product.IsFavorite;
        Products[index] = product;
    });

    public List<Product> mapProducts = new List<Product>()
        {
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 10,
                IsActive = true,
                IsDiscount = false,
                IsFavorite = true,
                Name = "Fenerbahçe Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 50,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Galatasaray Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 40,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Beşiktaş Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 10,
                IsActive = true,
                IsDiscount = false,
                IsFavorite = true,
                Name = "Fenerbahçe Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 50,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Galatasaray Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 40,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Beşiktaş Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 10,
                IsActive = true,
                IsDiscount = false,
                IsFavorite = true,
                Name = "Fenerbahçe Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 50,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Galatasaray Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 40,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Beşiktaş Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 10,
                IsActive = true,
                IsDiscount = false,
                IsFavorite = true,
                Name = "Fenerbahçe Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 50,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Galatasaray Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            },
            new Product
            {
                CreatedDate = DateTime.Now,
                Description = "",
                DiscountRate = 40,
                IsActive = true,
                IsDiscount = true,
                IsFavorite = false,
                Name = "Beşiktaş Forması",
                Price = 250,
                Unit = "1 Adet",
                UpdatedDate = DateTime.Now,
                ImageId = ""
            }
        };
}
