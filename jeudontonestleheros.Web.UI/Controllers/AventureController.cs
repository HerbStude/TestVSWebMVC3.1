using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            
            ViewBag.MonTitre = "Aventures";


            #region Nouvelle Méthode List<>
            List<AventureViewModel> maList = new List<AventureViewModel>
            {
                new AventureViewModel()
                {
                    Id = 1,
                    Titre = "Ma première aventure"
                },

                new AventureViewModel()
                {
                    Id = 2,
                    Titre = "Ma seconde aventure"
                }
            };
            #endregion

            #region Ancienne méthode List<>
            /*
            List<AventureViewModel> maList = new List<AventureViewModel>();

            maList.Add(new AventureViewModel()
            {
                Id = 1,
                Titre = "Ma première aventure"
            });

            maList.Add(new AventureViewModel()
            {
                Id = 2,
                Titre = "Ma seconde aventure"
            });*/
            #endregion

            return View(maList);
        }
    }
}