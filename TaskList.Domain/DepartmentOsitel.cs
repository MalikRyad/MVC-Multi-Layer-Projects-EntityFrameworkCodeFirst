using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskList.Domain
{
  public  class DepartmentOsitel : BaseEntity
    {


        [Required]
        [StringLength(255)]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
        [Display(Name = "Is completed?")]
        public bool IsCompleted { get; set; } = false;

       
    }
}
