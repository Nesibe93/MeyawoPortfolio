using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class EducationController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities(); // Nesne örneği oluşturma/Nesne türetme
        public ActionResult Index()
        {
            var values = db.TblEducation.ToList();
            return View(values);
        }
       
    }
}