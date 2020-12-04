using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Personel
    {
        [Key]
        public int perId { get; set; }
        public string Url { get; set; }
        public string perName { get; set; }
        public string perSurname { get; set; }
        public string perCity { get; set; }
    }
}
