using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab4.Models;
using lab4.ViewModels.Home;

namespace lab4.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList()
        {
            var factory = new CarFactory();


            var viewModel = new CarListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}