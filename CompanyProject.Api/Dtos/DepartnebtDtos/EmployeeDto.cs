﻿using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Api.Dtos.DepartnebtDtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

     
        public string LastName { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public int SubDepartmentId { get; set; }
    }
}
