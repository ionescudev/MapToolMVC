using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapToolMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<MapModel> model = JsonConvert.DeserializeObject<List<MapModel>>( System.IO.File.ReadAllText(Server.MapPath("~/JsonModels/Simple.json")) );

            return View(model);
        }

        [HttpPost]
        public ActionResult IndexPost()
        {

            List<MapModel> model = JsonConvert.DeserializeObject<List<MapModel>>(Request.Form["postTextArea"]);

            return View("~/Views/Home/Index.cshtml",model);
        }


    }
    public class MapModel
    {
        public string Id { get; set; }
        public decimal CoordX { get; set; }
        public decimal CoordY { get; set; }
        public int Duration { get; set; }
        public List<object> TimeWindows { get; set; }
    }
}