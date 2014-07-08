using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewStudentProject.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal? Grade { get; set; }
        //Grade will accept null values

        //properties represent the relationships
        //every Enrollment has access to one Student & Course

        public virtual Student student { get; set; }
        public virtual Course course { get; set; }

        //virtual enables displaying null 

    }
}