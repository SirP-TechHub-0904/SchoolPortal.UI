using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Hrssu.Models.Entities
{
    public class ClassLevel
    {
        public ClassLevel()
        {
            ShowPositionOnClassResult = true;
        }

        public int Id { get; set; }

        [Display(Name = "Class:")]
        [Required(ErrorMessage = "Class is required")]
        public string ClassName { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public StaffProfile StaffProfile { get; set; }
        public int? SessionId { get; set; }
        public Session Session { get; set; }


        public decimal Passmark { get; set; }

        [Display(Name = "Mark for Promotion on Trial")]
        public decimal PromotionByTrial { get; set; }




        [Display(Name = "Accessment Total Score")]
        public decimal AccessmentScore { get; set; }

        [Display(Name = "Exam Total Score")]
        public decimal ExamScore { get; set; }

        [Display(Name = "Show Position on Result")]
        public bool ShowPositionOnClassResult { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }


      
    }
}