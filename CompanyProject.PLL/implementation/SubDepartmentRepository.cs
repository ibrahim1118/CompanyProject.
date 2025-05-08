using CompanyProject.DAL;
using CompanyProject.DAL.Data;
using CompanyProject.PLL.interference;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.PLL.implementation
{
    public class SubDepartmentRepository : BaseRepository<SubDepartment> , ISubDepartmentRepository
    {
        private readonly AppDbContext _context;

        public SubDepartmentRepository(AppDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<SubDepartment>> GetAllSubDepartmentWithDetilsAsync()
        {
            return await _context.SubDepartments.Include(x=>x.Employees).ToListAsync();
        }

        public async Task<SubDepartment> GetSubDepartmentWithDetilByIdAsync(int id)
        {
            return await _context.SubDepartments.Where(x => x.Id == id).Include(x => x.Employees).FirstOrDefaultAsync(); 
                
        }
    }
}
