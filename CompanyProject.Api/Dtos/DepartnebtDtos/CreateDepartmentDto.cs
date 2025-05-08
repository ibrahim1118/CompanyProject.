using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Api.Dtos.DepartnebtDtos
{
    public class CreateDepartmentDto
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
