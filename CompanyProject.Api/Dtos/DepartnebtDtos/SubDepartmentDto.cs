using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Api.Dtos.DepartnebtDtos
{
    public class SubDepartmentDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public int EmployeesNumber { get; set; }
        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
    }
}
