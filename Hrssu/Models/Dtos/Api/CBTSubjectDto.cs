using Hrssu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos.Api
{
    public class CBTSubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "School Link")]
        public string SchoolLink { get; set; }

        public ICollection<QuestionModel> QuestionModel { get; set; }
    }
}