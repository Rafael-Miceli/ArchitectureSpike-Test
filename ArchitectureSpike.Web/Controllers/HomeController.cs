using System.Web.Mvc;
using ArchitectureSpike.Data.Repositories;
using ArchitectureSpike.Domain.Interfaces;
using ArchitectureSpike.Domain.Services;

namespace ArchitectureSpike.Web.Controllers
{
    public class HomeController : Controller
    {
        private AssociateService _associateService = new AssociateService(new GenericRepository<IAssociateEntitie>());

        //public HomeController(AssociateService associateService)
        //{
        //    _associateService = associateService;
        //}

        public ActionResult Index()
        {
            return View(_associateService.GetById(1));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
