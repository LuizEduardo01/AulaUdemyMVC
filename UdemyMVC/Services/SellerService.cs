﻿
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            {
                throw new NotFoundException("ID not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
           
        }
    }
}