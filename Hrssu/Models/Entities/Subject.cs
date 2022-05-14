using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Hrssu.Models.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        [Display(Name = "Subject:")]
        [Required(ErrorMessage = "Subject is required")]
        public string SubjectName { get; set; }

        public int ClassLevelId { get; set; }
        public ClassLevel ClassLevel { get; set; }

        public decimal? ExamScore { get; set; }
        public decimal? TestScore { get; set; }

        public decimal? PassMark { get; set; }

       

        [UIHint("Enum")]
        public RequiresPass RequiresPass { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}