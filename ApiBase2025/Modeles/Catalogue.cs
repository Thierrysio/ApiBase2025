using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase2025.Modeles
{
    public class Catalogue
    {
        #region Proprietes
        private int _id;
        #endregion

        #region Constructeurs
       
        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        #endregion

        #region Methodes
        #endregion
    }
}