using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data
{
    public class AventureViewModel
    {
        #region Propriété
        /// <summary>
        /// C'est l'id de chaque aventure
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// C'est le titre de chaque aventure
        /// </summary>
        public string Titre { get; set; }
        #endregion
    }
}
