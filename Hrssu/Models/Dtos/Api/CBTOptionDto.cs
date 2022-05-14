using Hrssu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hrssu.Models.Dtos.Api
{
    public class CBTOptionDto
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