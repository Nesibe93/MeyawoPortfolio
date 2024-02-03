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
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(TblEducation p)
        {
            db.TblEducation.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(TblEducation p)
        {
            var value = db.TblEducation.Find(p.EducationID);
            value.Degree = p.Degree;
            value.UniversityName = p.UniversityName;
            value.DepartmentName = p.DepartmentName;
            value.GPA = p.GPA;
            value.GraduationDate = p.GraduationDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}