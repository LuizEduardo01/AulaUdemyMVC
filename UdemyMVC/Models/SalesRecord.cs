using System;
using UdemyMVC.Models.Enums;

namespace UdemyMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amonth { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Saller { get; set; }

        public SalesRecord() 
        {
        }

        public SalesRecord(int id, DateTime date, double amonth, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amonth = amonth;
            Status = status;
            Saller = seller;
        }
    }
}
