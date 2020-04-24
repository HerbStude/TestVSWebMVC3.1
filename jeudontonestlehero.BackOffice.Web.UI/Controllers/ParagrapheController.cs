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
        #region Méthode publique
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }
        #endregion
    }
}