using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class CheckResultViewModelDto
    {
        [Required(ErrorMessage = "The Session year and Term has not been selected")]
        public int SessionId { get; set; }

        [Required(ErrorMessage = "Sudents PIN is required")]
        [Display(Name = "Student's ID Number")]
        public string StudentPIN { set; get; }

        [Required(ErrorMessage = "PIN Number is required")]
        [Display(Name = "PIN Number")]
        [DataType(DataType.Password)]
        public string PinNumber { get; set; }

        [Required(ErrorMessage = "Serial Number is required")]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}