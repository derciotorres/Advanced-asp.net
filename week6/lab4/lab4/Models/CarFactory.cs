using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab4.Models
{
    public class CarFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarFactory()
        {
            Database.SetInitializer(new carInitializer());
        }
    }
    public class carInitializer : DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context)
        {
            {
                context.Cars.Add(new Car() { Model = "Rabbit", MaxSpeed = 300 });
                context.Cars.Add(new Car() { Model = "Turtle", MaxSpeed = 150 });
            }


        }
    }
}