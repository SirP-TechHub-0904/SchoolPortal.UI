using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class Enrollment
    {
 
        public int Id { get; set; }

      
        public int? ClassLevelId { get; set; }
        public ClassLevel ClassLevel { get; set; }
        //public string Username { get; set; }
        public int StudentProfileId { get; set; }
        public StudentProfile StudentProfile { get; set; }
        public ApplicationUser User { get; set; }

        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Average Score")]
        public decimal? AverageScore { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cummulative Average Score")]
        public decimal? CummulativeAverageScore { get; set; }

      
        public string EnrollmentRemark { get; set; }

        [Display(Name = "HeadTeacher's Remark")]
        public string EnrollmentRemark1 { get; set; }

        [Display(Name = "Teacher's Remark")]
        public string EnrollmentRemark2 { get; set; }

        [Display(Name = "Next Term Resumption Date")]
        public string NextResumption { get; set; }

        public RecognitiveDomain RecognitiveDomain { get; set; }


        public virtual ICollection<EnrolledSubject> EnrolledSubjects { get; set; }
    }
}