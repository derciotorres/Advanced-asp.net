using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practice.Models
{
    public class AlbumDB :DbContext
    {

        public DbSet<Album> Albums { get; set; }

        public AlbumDB() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new AlbumInitializer());

        }

    }


    public class AlbumInitializer: DropCreateDatabaseIfModelChanges<AlbumDB>
    {

        protected override void Seed(AlbumDB context)
        {
            {


                context.Albums.Add(new Album() { Number_Tracks = "12", Album_Name = "Walker" });

                context.Albums.Add(new Album() { Number_Tracks = "15", Album_Name = "Samba" });

                context.Albums.Add(new Album() { Number_Tracks = "17", Album_Name = "King" });


            }
        }






    }
}