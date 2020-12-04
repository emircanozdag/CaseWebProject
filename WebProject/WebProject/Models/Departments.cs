using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string DepartmentName { get; set; }
    }
}
