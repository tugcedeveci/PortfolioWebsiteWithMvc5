using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim

        GenericRepository<TblEgitim> repo = new GenericRepository<TblEgitim>();
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEgitim p)
        {
            if (!ModelState.IsValid) //modelin durum geçerliliği sağlanmadıysa
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}