using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region A supprimer après intityes
        private List<Paragraphe> maList = new List<Paragraphe>()
        {
            new Paragraphe() { Id = 1, Numero = 1, Titre = "Titre 1"},
            new Paragraphe() { Id = 2, Numero = 10, Titre = "Titre 2"},
            new Paragraphe() { Id = 3, Numero = 14, Titre = "Titre 3"}
        };
        #endregion


        #region Méthode publique
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = maList.First(item => item.Id == id);
            return View(paragraphe);
        }
        #endregion
    }
}