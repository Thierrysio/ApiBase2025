using ApiBase2025.Modeles;
using ApiBase2025.Services;

namespace ApiBase2025.Vues;

public partial class VueObjetProduit : ContentPage
{
    private readonly Apis _api = new Apis();

    public VueObjetProduit()
	{
		InitializeComponent();
		this.recupererObjet();
	}

	private async Task<Produit> recupererObjet()
	{
		Produit resultat ;
		Produit P = new Produit(2);
		//imlementation de l'appel a l'Api (api/mobile/getProduit) et retour de l'objet
		resultat = await _api.GetOneAsync<Produit>("api/mobile/getProduit", P);
        return resultat;
	}

}