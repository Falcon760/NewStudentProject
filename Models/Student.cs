using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewStudentProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        //specifies that every students has multiple enrollments 
        //virtual specifies lazy loading
    }
}