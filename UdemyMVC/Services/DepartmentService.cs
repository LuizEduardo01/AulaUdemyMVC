using System.Collections.Generic;
using System.Linq;
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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
