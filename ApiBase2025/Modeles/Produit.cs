using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase2025.Modeles
{
    public class Produit
    {
        #region Proprietes
        private int _id;
        private string _nomProduit;
        private List<Promo> _lesPromos;
         #endregion

        #region Constructeurs

        public Produit()
        { }
        public Produit(int id, string nomProduit)
        {
            Id = id;
            NomProduit = nomProduit;
            LesPromos = new List<Promo>(); 
        }
        
        public Produit(int id)
        {
            Id = id;
        }

        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }
        [JsonProperty("nomProduit")]
        public string NomProduit { get => _nomProduit; set => _nomProduit = value; }
        [JsonProperty("lesPromos")] 
        public List<Promo> LesPromos { get => _lesPromos; set => _lesPromos = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
