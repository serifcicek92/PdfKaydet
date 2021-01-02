using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IronPdf;

namespace pdfkaydet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Link)
        {
            //string linki = Link;
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderUrlAsPdf(Link);
            PDF.SaveAs(@"C:\Users\serif\Desktop\isimkoy.pdf");
            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(@"C:\Users\serif\Desktop\isimkoy.pdf");
            return View("Pdf Kayıtedildi");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}