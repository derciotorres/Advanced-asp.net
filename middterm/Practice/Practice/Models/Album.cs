using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Album
    {
        [Key]
        public int Album_Id { get; set; }
        public string Number_Tracks { get; set; }
        public string Album_Name { get; set; }
       
    }
}