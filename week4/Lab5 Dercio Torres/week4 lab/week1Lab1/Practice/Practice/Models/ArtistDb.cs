using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practice.Models
{
    public class ArtistDb : DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        public ArtistDb()
        {
            Database.SetInitializer(new artistInitializer());
        }
    }

    public class artistInitializer : DropCreateDatabaseIfModelChanges<ArtistDb>
    {
        protected override void Seed(ArtistDb context)
        {
            {
                context.Artists.Add(new Artist() { ArtistName = "Bananas", Email = "300", Date = new DateTime(2008, 12, 25) });

                context.Artists.Add(new Artist() { ArtistName = "lalalal", Email = "3eee00", Date = new DateTime(2008, 12, 15) });
            }


        }

    }
}