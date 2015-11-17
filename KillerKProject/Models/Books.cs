using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KillerKProject.Models
{
    public class Books
    {
        //testing commits 
        public string BooksID;

        public string Title;

        public string Author;

        public string Genre;

        public int Rating;

        public int BooksInStock;

        public int BooksOnOrder;

        public DateTime PublicationDate;

        public int PriceForCustomer;

        public int PricePaidForBook;

        public Boolean isForSale;

        public int AutomaticReorderPoint;

        public int ReviewID;


    }
}