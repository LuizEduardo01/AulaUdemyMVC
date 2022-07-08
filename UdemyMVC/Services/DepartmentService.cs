<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.Collections.Generic;
using System.Linq;
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
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
<<<<<<< HEAD
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
=======
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
>>>>>>> 6e5cc5f9629c98961ffd41e0fc720c309fb2b781
        }
    }
}
