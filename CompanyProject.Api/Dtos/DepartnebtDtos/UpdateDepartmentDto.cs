﻿using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Api.Dtos.DepartnebtDtos
{
    public class UpdateDepartmentDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
