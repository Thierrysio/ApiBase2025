using ApiBase2025.Modeles;
using ApiBase2025.Services;
using System.Collections.ObjectModel;

namespace ApiBase2025.Vues;

public partial class VueListeProduits : ContentPage
{
    private readonly Apis _api = new Apis();

    public VueListeProduits()
	{
		InitializeComponent();
        this.LoadProduits();

    }

    private async void LoadProduits()
    {
        try
        {
            ObservableCollection<Produit> result = 
                await _api.GetAllAsync<Produit>("/api/mobile/produits");

        }
        catch (Exception ex)
        {
            //await DisplayAlert("Erreur", $"Impossible de charger les produits : {ex.Message}", "OK");
        }
    }
}