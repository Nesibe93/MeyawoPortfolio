using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
    }
}