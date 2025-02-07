using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? Salary { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }
    }
}
