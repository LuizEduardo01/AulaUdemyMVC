

using System.Collections.Generic;
using System.Linq;
using UdemyMVC.Models;

namespace UdemyMVC.Services
{
    public class SellerService
    {
        private readonly UdemyMVCContext _context;

        public SellerService(UdemyMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
