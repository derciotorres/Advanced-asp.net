using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Allows us to set Key (Primary Key)


namespace MVC_Lesson5_EntityFramework.Models
{
    public class Manufacturer
    {
        //Simple car properties
        [Key]
        public int Manufacturer_ID { get; set; }         //Primary key for Manufacturer

        [Required(ErrorMessage = "Car Manufacturer is required")]                              //Field cannot be left blank/null
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]              //Must be 2 or more chars
        public string Make { get; set; }       //Car Manufacturer

        public virtual ICollection<Car> Cars { get; set; }      //List of associated Cars
    }
}