using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Hrssu.Models.Entities
{
    public class OptionModel
    {
        public int Id { get; set; }

        [AllowHtml]
        public string Name { get; set; }

        [Display(Name = "Question")]
        public int? QuestionModelId { get; set; }
        public QuestionModel QuestionModel { get; set; }

        [Display(Name = "Correct Option")]
        public bool IsAnswer { get; set; }

        [Display(Name = "School Link")]
        public string SchoolLink { get; set; }
    }
}