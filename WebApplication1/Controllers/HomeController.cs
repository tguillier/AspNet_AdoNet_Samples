using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new IndexViewModel
            {
                MessagePromotionnel = "Achetez ce produit de fou ! Quantité extra limitée !!!",
                ProduitVedette = new Product
                {
                    Id = 5,
                    Name = "Produit de fou !",
                    Quantity = 10
                }
            });
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

        [ChildActionOnly]
        public ActionResult Menu()
        {
            return PartialView("MenuPartial");
        }
    }
}