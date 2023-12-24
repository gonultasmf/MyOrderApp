using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class LoginPageViewModel : BaseViewModel
{
    private readonly IUserRepository _repository;

    [ObservableProperty]
    private bool _isControl;

    [ObservableProperty]
    private User _user;

    public LoginPageViewModel(IUserRepository repository)
    {
        _repository = repository;
        var temp = _repository.GetAll();
    }


    public ICommand LoginCommand => new Command(async () =>
    {
        var temp = _repository.GetAll(u => u.IsActive && u.Username == User.Username && u.Password == User.Password);
        var user = _repository.Get(u => u.IsActive && u.Username == User.Username && u.Password == User.Password);

        if (user == null)
            await Shell.Current.DisplayAlert("HATA", "Kullanıcı Adı veya Şifre yanlış!", "OK");
        else
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    });
}
