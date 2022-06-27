using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbacusAcademy.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseDuration { get; set; }
        [JsonIgnore]
        public Institute Institute { get; set; }
       [ForeignKey("Institute")]
        public int InstituteId { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
