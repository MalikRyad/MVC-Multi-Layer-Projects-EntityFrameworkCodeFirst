using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskList.Domain
{
  public   class EmployeeOsitel : BaseEntity
    {


        [Required]
        [StringLength(255)]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Display(Name = "Is completed?")]
        public bool IsCompleted { get; set; } = false;

    }
}
