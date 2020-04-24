using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Paragraphe
    {
        #region Propriété
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// C'est le titre du paragraphe
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Description du paragraphe
        /// </summary>
        public Questions MaQuestion { get; set; }
        #endregion
    }
}
