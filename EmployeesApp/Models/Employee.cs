using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    [Table("Employee")]
    public class Employee
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Имя сотрудника")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Account number is required")]
        [Display(Name = "Страховой номер")]
        public string? AccountNumber { get; set; }
    }
}
