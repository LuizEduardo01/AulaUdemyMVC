using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyMVC.Models;

namespace UdemyMVC.Services
{
    public class DepartmentService
    {
        private readonly UdemyMVCContext _context;

        public DepartmentService(UdemyMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
