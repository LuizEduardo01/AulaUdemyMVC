using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Models
{
    public class UdemyMVCContext : DbContext
    {
        
        public UdemyMVCContext (DbContextOptions<UdemyMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord { get; set; }
    }

}
