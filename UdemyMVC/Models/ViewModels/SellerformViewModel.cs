

using System.Collections.Generic;

namespace UdemyMVC.Models.ViewModels
{
    public class SellerformViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments{ get; set; }
    }
}
