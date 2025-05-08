using CompanyProject.DAL;
using CompanyProject.DAL.Data;
using CompanyProject.PLL.implementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.PLL.interference
{
    public class DepartmentRepository : BaseRepository<Department> ,IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context): base(context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentWithDetilsAsync()
        {
           return await _context.Departments.Include(x=>x.SubDepartments)
                .ThenInclude(x=>x.Employees).ToListAsync();
        }

        public async Task<Department> GetDepartmentWithDetilByIdAsync(int id)
        {
            return await _context.Departments.Include(x=>x.SubDepartments).
                ThenInclude(x=>x.Employees).Where(x=>x.Id==id).FirstOrDefaultAsync();
        }
    }
}
