using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase2025.Modeles
{
    public class CategoriePromo
    {
        #region Proprietes
        private int _id;
        private string _nom;

      
        #endregion

        #region Constructeurs
        public CategoriePromo(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        #endregion

        #region Getters/Setters
        [JsonProperty("id")] 
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nom")] 
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
