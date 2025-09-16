using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase2025.Modeles
{
    public class Promo
    {
        #region Proprietes
        private int _id;
        private double _prix;
        private CategoriePromo _laCategoriePromo;


        #endregion

        #region Constructeurs
        public Promo(int id, double prix, CategoriePromo laCategoriePromo)
        {
            Id = id;
            Prix = prix;
            LaCategoriePromo = laCategoriePromo;
        }


        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }
        [JsonProperty("prix")]
        public double Prix { get => _prix; set => _prix = value; }
        [JsonProperty("laCategoriePromo")]
        public CategoriePromo LaCategoriePromo { get => _laCategoriePromo; set => _laCategoriePromo = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
