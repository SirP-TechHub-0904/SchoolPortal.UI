using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class SettingLayoutDto
    {
        public int Id { get; set; }
      
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "Short Name")]
        public string SchoolInitials { get; set; }

       

        [Display(Name = "Contact Mail")]
        public string ContactEmail { get; set; }
        

        public byte[] Image { get; set; }

        

    }
}