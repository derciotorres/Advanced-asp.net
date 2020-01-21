using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;   //Added in order to use DB Context

namespace MVC_Lesson5_EntityFramework.Models
{
    public class CarFactory : DbContext      //inherit the  DbContext to allow Entity Framework to manage DB's
    {
        public DbSet<Car> Cars { get; set; }    //Create a set of DB Entities that can work with "Car" instances in a table

        //Default constructor
        public CarFactory()
        {
            Database.SetInitializer(new CarInitializer());  //Initializes the DB
        }
    }

    //What do you think we are inheriting?
    public class CarInitializer: DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context)    //Method to seed the table with sample data
        {
            {
                context.Cars.Add(new Car() { Model = "Millenium Falcon", MaxSpeed = 300, ImageName = "mfalcon" });       //Add the fastest hunk of junk

                context.Cars.Add(new Car() { Model = "Space Runner", MaxSpeed = 150, ImageName = "buck" });       //add Snow-Speeder rip-off

                context.Cars.Add(new Car() { Model = "Y-Wing", MaxSpeed = 150, ImageName = "ywing" });       //add slow but sturdy

                context.Cars.Add(new Car() { Model = "The Enterprise", MaxSpeed = 150, ImageName = "Enterprise" });       //add an old reliable
            }
        }
    }
}