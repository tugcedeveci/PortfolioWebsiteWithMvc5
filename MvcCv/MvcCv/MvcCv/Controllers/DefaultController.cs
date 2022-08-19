using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;


namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList(); //Hakkimda tablosunda yer alan verileri listelesin
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler); // View tarafında birden fazla bölme işlemi yapılacaksa kullanılan alanlardır.
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitim.ToList();
            return PartialView(egitimler);

        }
        public PartialViewResult Yetenekler()
        {
            var yetenekler = db.TblYetenekler.ToList();
            return PartialView(yetenekler);

        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);

        }

        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TbIletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TbIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }

        //Repository Design Pattern : Tekrardan kurtulmak amaç

    }
}