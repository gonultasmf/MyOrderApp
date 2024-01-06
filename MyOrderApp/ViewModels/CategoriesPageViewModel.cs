using AutoMapper;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;

namespace MyOrderApp.ViewModels;

public partial class CategoriesPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<CategoryVM> _categories;

    private readonly ICategoryRepository _categoryRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public CategoriesPageViewModel(ICategoryRepository categoryRepository, 
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        Categories = categories.ToObservableCollection();
    }


    public List<CategoryVM> categories = new List<CategoryVM>()
        {
            new CategoryVM
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Başlık 1",
                UpdatedDate = DateTime.Now,
                SubCategories = new List<SubCategoryVM>
                {
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Yeniler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Unlu Mamülleri",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Meyveler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                }
            },

            new CategoryVM
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Meat",
                UpdatedDate = DateTime.Now,
                SubCategories = new List<SubCategoryVM>
                {
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Balıklar",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Kafeler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Soda",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                }
            },

            new CategoryVM
            {
                CreatedDate = DateTime.Now,
                IsActive = true,
                Name = "Tümü",
                UpdatedDate = DateTime.Now,
                SubCategories = new List<SubCategoryVM>
                {
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Yeniler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Unlu Mamülleri",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Meyveler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Balıklar",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Kafeler",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                    new SubCategoryVM
                    {
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        Name = "Soda",
                        UpdatedDate = DateTime.Now,
                        IconId = "",
                        Icon = "dotnet_bot.svg"
                    },
                }
            },
        };
}
