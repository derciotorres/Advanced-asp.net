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

        public ArtistDb()  : base("name=DefaultConnection")
        {
            Database.SetInitializer(new artistInitializer());
        }
    }

    public class artistInitializer : DropCreateDatabaseIfModelChanges<ArtistDb>
    {
        protected override void Seed(ArtistDb context)
        {
            {
                context.Artists.Add(new Artist() { ArtistName = "Taylor Swift", Email = "Taylor@gmail.com", Date = new DateTime(2008, 12, 25) });

                context.Artists.Add(new Artist() { ArtistName = "Justin Bieber", Email = "JustinBieber@gmail.com", Date = new DateTime(2000, 02, 15) });

                context.Artists.Add(new Artist() { ArtistName = "Michael Jackson", Email = "MichaelJackson@gmail.com", Date = new DateTime(1958, 06, 29) });
            }


        }

    }
}