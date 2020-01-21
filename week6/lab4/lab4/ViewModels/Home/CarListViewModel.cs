using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab4.Models;


namespace lab4.ViewModels.Home
{
    public class CarListViewModel
    {
        public IEnumerable<SelectListItem>CarList { get; private set; }

        public Car FastestCar { get; set; }

        public CarListViewModel(IEnumerable<Car> cars)
        {
            CarList = cars.Select(c => new SelectListItem() { Text = c.Model });
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();

        }
    }
}