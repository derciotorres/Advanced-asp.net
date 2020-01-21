using MVC_Lesson5_EntityFramework.Models;           //Use our CarFactory class
using MVC_Lesson5_EntityFramework.ViewModels.Home;  //use our ViewModel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Lesson5_EntityFramework.Controllers
{
    public class CarsController : Controller
    {

        //Declare Car factory object  to access it's Car-based resources
        private CarFactory Db = new CarFactory();


        public ActionResult CarsList()
        {
            //factory -> a new instance of the CarFactory model
            var factory = new CarFactory();

            //viewModel -> the viewmodel filled with the cars list
            var viewModel = new CarsListViewModel(factory.Cars);

            return View(viewModel);
        }


        public ActionResult ListofCars(string searchCriteria)
        {
            /* OLD CODE
            //factory -> a new instance of the CarFactory model
            var factory = new CarFactory();

            //Create a list of the cars from the DB Table
            var cars = new CarFactory().Cars.ToList();

            return View(cars);
            */

            //******************************************
            // NEW CODE - Notice the new parameter in this method/action
            //******************************************
            //Create Car DB table interface instance
            var factory = new CarFactory();

            //Make a DB table instance that can be queried using params.
            IQueryable<Car> cars = factory.Cars.OrderBy(p => p.Model);

            //Find records that match
            if (searchCriteria != null)
            {
                cars = cars.Where(p => p.Model.Contains(searchCriteria));
            }

            //Create list of first 10 matches and returns this list
            var carlist = cars.Take(10).ToList();
            return View(carlist);
            //******************************************
        }



        public ActionResult Details(int id)
        {
            //Declare the car factory var in order to interact with table of cars
            var factory = new CarFactory();

            Car found = factory.Cars.Where(p => p.Car_ID == id).FirstOrDefault();

            return View(found);
        }




    }
}