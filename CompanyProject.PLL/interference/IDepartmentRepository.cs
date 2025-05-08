using CompanyProject.DAL.Data;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.PLL.implementation
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        Task<IEnumerable<Department>> GetAllDepartmentWithDetilsAsync();
        Task<Department> GetDepartmentWithDetilByIdAsync(int id);
    }
}
