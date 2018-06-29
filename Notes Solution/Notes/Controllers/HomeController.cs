using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notes.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            Notes.Models.NotesModel model = new Models.NotesModel();
            model.Categories = FakeDb.FakeDB.GetCategories().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCategory(Notes.Models.NotesModel model)
        {
            // makes sure nothing malicious comes in, a properly set up razor view will do this for us.
            string name = Server.HtmlEncode(model.NewCategoryName);

            // TODO: attempt category save
            FakeDb.FakeDB.AddCategory(name);

            return RedirectToAction("Index");
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