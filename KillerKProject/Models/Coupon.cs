using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KillerKProject.Models
{
    public class Coupon
    {
        public int CouponID { get; set; }

        [Required]
        public string CouponCode { get; set; }

        public enum CouponTypes
        {   [Display(Name="Shipping Discount")]
            ShippingDiscount,
            [Display(Name="Percent Off Discount")]
            PercentOffDiscount

        }

        [Required]
        public CouponTypes CouponType { get; set; }

        //is this how we should do this?
        public int ShippingMinimum { get; set; }
        public int PercentOffValue { get; set; }
    }
}