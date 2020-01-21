using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Artist
    {
        [Key]
        public int Artist_Id { get; set; }
        public string ArtistName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}