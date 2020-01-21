using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Allows us to set Key (Primary Key)

namespace MVC_Lesson5_EntityFramework.Models
{
    public class Car
    {
        //Simple car properties
        [Key]
        public int Car_ID { get; set; }         //Primary key for car

        [Required(ErrorMessage = "Car Model is required")]                              //Field cannot be left blank/null
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]              //Must be 2 or more chars
        public string Model { get; set; }       //Car Model


        [Range(10, 300)]                        //Entries must stay within the specified range (min, max)
        public double MaxSpeed { get; set; }    //What is its maximum (fastest) speed?

        public string ImageName { get; set; }   //string to hold image filename

        public int Manufacturer_ID { get; set; }   //string to hold image filename

        public virtual Manufacturer Manufacturer { get; set; }      //Will link us to the associated Manufacturer table
    }
}