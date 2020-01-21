using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Lesson5_EntityFramework.Models
{
    public class Lesson8Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Lesson8Context() : base("name=Lesson8Context")
        {
        }

        public System.Data.Entity.DbSet<MVC_Lesson5_EntityFramework.Models.Manufacturer> Manufacturers { get; set; }

        public System.Data.Entity.DbSet<MVC_Lesson5_EntityFramework.Models.Car> Cars { get; set; }
    }
}
