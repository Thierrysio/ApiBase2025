using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase2025.Modeles
{
    public class SuperCatalogue
    {
        #region Proprietes
        private Catalogue _catalogues;


        #endregion

        #region Constructeurs
       
        #endregion

        #region Getters/Setters
        [JsonProperty("catalogues")]
        public Catalogue Catalogues { get => _catalogues; set => _catalogues = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
