using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbacusAcademy.Entities
{
    public class Institute
    {
        [Key]
        public int InstituteId { get; set; }
        public string InstituteName { get; set; }
        public string InstituteDescription { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public ICollection<Course> Courses { get; set;}
        public ICollection<Student> Students { get; set; }
    }
}
