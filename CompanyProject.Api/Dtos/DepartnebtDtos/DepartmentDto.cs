

namespace CompanyProject.Api.Dtos.DepartnebtDtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }    
        public string Description { get; set; } 
        public int SubDepartmentsNumber { get; set; }
        public List<SubDepartmentDto> SubDepartments { get; set;  } =new List<SubDepartmentDto>();  
    }
}
