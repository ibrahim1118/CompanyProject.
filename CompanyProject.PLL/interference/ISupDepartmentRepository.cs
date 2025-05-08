using CompanyProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.PLL.implementation
{
    public interface ISubDepartmentRepository : IBaseRepository<SubDepartment>
    {
        Task<IEnumerable<SubDepartment>> GetAllSubDepartmentWithDetilsAsync();
        Task<SubDepartment> GetSubDepartmentWithDetilByIdAsync(int id);
    }
}
