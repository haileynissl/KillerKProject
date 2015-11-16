using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KillerKProject.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int BookID { get; set; }
        [ForeignKey("BookID")]
        [Required]
        public virtual Books ReviewedBook { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "Review")]
        public String ReviewText { get; set; }


        [Required]
        [Range(1, 5)]
        [Display(Name = "Rating (1-5)")]
        public int Rating { get; set; }


        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        [Required]
        public virtual Customer Reviewer { get; set; }

        [Display(Name = "Approved")]
        public bool IsApproved { get; set; }
    }
}