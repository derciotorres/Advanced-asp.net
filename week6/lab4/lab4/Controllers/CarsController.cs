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

        private CarFactory Db = new CarFactory();

        // GET: Cars
        public ActionResult CarsList()
        {
            var factory = new CarFactory();


            var viewModel = new CarListViewModel(factory.Cars);

            return View(viewModel);
        }


        public ActionResult ListofCars(string searchCriteria)
        {
            /*   var factory = new CarFactory();

               var cars = new CarFactory().Cars.ToList();

               return View(cars);
              */

            var factory = new CarFactory();
            IQueryable<Car> cars = factory.Cars.OrderBy(p => p.Model);

            if (searchCriteria != null)
            {

                cars = cars.Where(p => p.Model.Contains(searchCriteria));

            }

            var carlist = cars.Take(2).ToList();
            return View(carlist);



        }

        public ActionResult Details (int id)
        {
            var factory = new CarFactory();

            Car found = factory.Cars.Where(p => p.Car_ID == id).FirstOrDefault();

            return View(found);
        }

    }
}