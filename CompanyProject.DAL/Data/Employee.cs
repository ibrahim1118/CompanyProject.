using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.DAL.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }
      
        public int SubDepartmentId { get; set; }

        [ForeignKey("SubDepartmentId")]
        public virtual SubDepartment SubDepartment { get; set; }
    }
}
