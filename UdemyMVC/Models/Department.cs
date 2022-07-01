using System;
using System.Linq;
using System.Collections.Generic;

namespace UdemyMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sallers { get; set; } = new List<Seller>();

        public Department() 
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller saller) 
        {
            Sallers.Add(saller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sallers.Sum(seller => seller.TotalSales(initial, final));
        }
        
    }
}
