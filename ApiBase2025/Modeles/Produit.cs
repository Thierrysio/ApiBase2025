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

         #endregion

        #region Constructeurs
        public Produit(int id, string nomProduit)
        {
            Id = id;
            NomProduit = nomProduit;
        }
        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }
        [JsonProperty("nomProduit")]
        public string NomProduit { get => _nomProduit; set => _nomProduit = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
