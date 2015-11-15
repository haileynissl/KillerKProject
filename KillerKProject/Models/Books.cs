using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerKProject.Models
{
    public class Books
    {
        public string BookID;

        public string Title;

        public string Author;

        public string Genre;

        public int Rating;

        public int NumberInStock;

        public int NumberOnOrder;

        public DateTime PublicationDate;

        public int PriceForCustomer;

        public int PricePaidForBook;

        public Boolean isForSale;

        public int AutomaticReorderPoint;


    }
}