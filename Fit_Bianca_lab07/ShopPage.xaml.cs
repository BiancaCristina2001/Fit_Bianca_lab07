using Fit_Bianca_lab07.Models;
namespace Nume_Pren_Lab7;
public partial class ShopPage : ContentPage
{

    public ShopPage()
    {
        InitializeComponent();

    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var shop = (Shop)BindingContext;
        await App.Database.SaveShopAsync(shop);
        await Navigation.PopAsync();
    }
}


