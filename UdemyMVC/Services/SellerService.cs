
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
using UdemyMVC.Models;
using UdemyMVC.Services.Excepitons;
using UdemyMVC.Services.Exceptions;

namespace UdemyMVC.Services
{
    public class SellerService
    {
        private readonly UdemyMVCContext _context;

        public SellerService(UdemyMVCContext context)
        {
            _context = context;
        }
<<<<<<< HEAD
        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }
        public async Task InsertAsync(Seller obj)
        {
           
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
=======
        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
           
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(x => x.Id == obj.Id))
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            {
                throw new NotFoundException("ID not found");
            }
            try
            {
                _context.Update(obj);
<<<<<<< HEAD
                await _context.SaveChangesAsync();
=======
                _context.SaveChanges();
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
           
        }
    }
}
