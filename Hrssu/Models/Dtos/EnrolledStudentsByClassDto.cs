using Hrssu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class EnrolledStudentsByClassDto
    {
        public int Id { get; set; }

       public string StudentRegNumber { get; set; }
       public string StudentName { get; set; }
       public int StudentId { get; set; }


        public decimal? AverageScore { get; set; }
        public decimal? TotalAverage { get; set; }

        public decimal? CummulativeAverageScore { get; set; }
        
        public int SubjectCount { get; set; }
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Display(Name = " Test Score:")]
        //[Range(0, 30)]
        public decimal? TestScore { get; set; }

        [Display(Name = "Exam Score:")]
        //[Range(0, 70)]
        public decimal? ExamScore { get; set; }

        [Display(Name = "Total Score:")]
        public decimal? TotalScore { get; set; }

        public int EnrollmentId { get; set; }
        public Enrollment Enrollments { get; set; }

        public string Session { get; set; }
        public string SessionYear { get; set; }
        public int SessionId { get; set; }

    }
}