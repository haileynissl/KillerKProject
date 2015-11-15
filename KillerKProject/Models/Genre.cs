using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KillerKProject.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public string GenreName { get; set; }
    }
}