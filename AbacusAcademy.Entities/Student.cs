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
    public class Student
    {
        [Key,ForeignKey("User")]
        public int StudentId { get; set; }
        [JsonIgnore]
        public virtual Users User { get; set; }
        public string StudentName { get; set; }
        public string StudentLastname { get; set; }
        public string StudentGender { get; set; }
        public string StudentFathername { get; set; }
        public string StudentMothername { get; set; }
        public string EmailId { get; set; }
        public string AlterMobile { get; set; }
        public DateTime? StudentDob { get; set; }
        public string Mobile { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string AreaName { get; set; }
        public string Nationality { get; set; }
        public int? Pincode { get; set; }
        public int? Age { get; set; }

        [JsonIgnore]
        public Institute Institute { get; set; }
        [ForeignKey("Institute")]
        public int InstituteId { get; set; }

        [JsonIgnore]
        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
    }
}
