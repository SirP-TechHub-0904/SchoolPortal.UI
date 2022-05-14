using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "School Link")]
        public string SchoolLink { get; set; }

        public ICollection<QuestionModel> QuestionModel { get; set; }
    }
}