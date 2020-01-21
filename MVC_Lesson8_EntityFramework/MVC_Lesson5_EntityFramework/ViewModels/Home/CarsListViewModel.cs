using MVC_Lesson5_EntityFramework.Models;   //to directly reference the Car class
using System.Web.Mvc;                       //using SelectListItem
using System.ComponentModel.DataAnnotations; //DB Key
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MVC_Lesson5_EntityFramework.ViewModels.Home
{
    //View Model to help create list-driven information
    public class CarsListViewModel
    {
        //List of Cars
        public IEnumerable<SelectListItem> CarsList { get; private set; }       

        //Car instance of the fastest car
        public Car FastestCar { get; set; }                                     


        //Constructor (Receiving a list of cars)
        public CarsListViewModel(IEnumerable<Car> cars)
        {
            //generate list of car Models
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });

            //Pointer to the fastest car
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();  
        }
    }
}