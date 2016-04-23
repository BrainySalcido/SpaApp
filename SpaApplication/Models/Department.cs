using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpaApplication.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Employee> Employee { get; set; }

    }
}