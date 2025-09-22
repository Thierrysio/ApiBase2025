using ApiBase2025.Modeles;
using ApiBase2025.Services;

namespace ApiBase2025.Vues;

public partial class VueObjetProduit : ContentPage
{
    private readonly Apis _api = new Apis();

    public VueObjetProduit(Produit P)
	{
		InitializeComponent();
		this.recupererObjet(P);
	}

    private async Task<Produit> recupererObjet(Produit P)
	{
		try 
		{
            return await _api.GetOneAsync<Produit>("api/mobile/getProduit", P);

        }
		catch(Exception e)
		{
            await DisplayAlert("Erreur", $"Impossible de charger les produits : {e.Message}", "OK");
			return;
        }


    }

}