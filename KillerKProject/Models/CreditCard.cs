using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KillerKProject.Models
{
    public class CreditCard
    {
        public int CCID { get; set; }

        [Required]
        [CreditCard]
        public int CCNumber { get; set; }

        public enum CCTypes
        {
            Visa,
            MasterCard,
            [Display(Name="American Express")]
            AmericanExpress,
            Discover
        }
        [Required]
        public CCTypes CCType { get; set; }
        
        //set up identity and figure 
        //out how to set up the foreign key

    }
}