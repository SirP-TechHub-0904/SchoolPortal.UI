using Hrssu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class EnrolledStudentsListDto
    {
       
        public int Id { get; set; }
        public string Fullname { get; set; }
        
            public decimal? TestScore { get; set; }
        
            public decimal? ExamScore { get; set; }
        
            public decimal? TotalScore { get; set; }
        
            public GradingOption GradingOption { get; set; }



        [Display(Name = "Grade:")]
        public string Grade
        {
            get;set;

        }


        [Display(Name = "Remark:")]
        public string Remark
        {
            get;set;
        }




    }
}