﻿using AutoMapper;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ProductVM> _products;

    [ObservableProperty]
    private ObservableCollection<SubCategoryVM> _categories;

    private readonly IProductRepository _productRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public HomePageViewModel(IProductRepository productRepository,
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _productRepository = productRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        GetHomePageInfos();
    }

    public ICommand GotoAllProductsCommand => new Command(async () =>
    {
        await Shell.Current.GoToAsync($"//{nameof(ProductsPage)}");
    });

    public ICommand GotoAllCategoriesCommand => new Command(async () =>
    {
        await Shell.Current.GoToAsync($"//{nameof(CategoriesPage)}");
    });

    public ICommand AddProductBasketCommand => new Command<ProductVM>((parameter) =>
    {
        if (BasketPageViewModel.BasketProduct.Any(x => x.Product.Id == parameter.Id))
            BasketPageViewModel.BasketProduct.First(x => x.Product.Id == parameter.Id).Count++;
        else
            BasketPageViewModel.BasketProduct.Add(new BasketProductVM { Count = 1, Product = parameter });
    });


    public ICommand ChangeFavoriteCommand => new Command((object parameter) =>
    {
        var product = (ProductVM)parameter;
        var index = Products.IndexOf(product);
        product.IsFavorite = !product.IsFavorite;
        Products[index] = product;
    });


    public ICommand SearchCommand => new Command(async (object val) =>
    {
        ProductsPage.Filter = (string)val;
        await Shell.Current.GoToAsync($"//{nameof(ProductsPage)}");
    });


    private void GetHomePageInfos()
    {
        Products = _mapper.Map<ObservableCollection<ProductVM>>(mapProducts.Take(5));
        Categories = _mapper.Map<ObservableCollection<SubCategoryVM>>(categories);
    }

    public static List<Product> mapProducts = new List<Product>()
        {
            new Product
            {
                Id = Guid.NewGuid(),
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
                Id = Guid.NewGuid(),
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
                Id = Guid.NewGuid(),
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

    public static List<SubCategory> categories = new List<SubCategory>()
        {
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Yeniler",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Unlu Mamülleri",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Meyveler",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Meat",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Balıklar",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Kafeler",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Soda",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
            new SubCategory
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Çörekler",
                UpdatedDate = DateTime.Now,
                IconId = ""
            },
        };
}
