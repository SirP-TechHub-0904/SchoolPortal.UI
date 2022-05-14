using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class LoginAccessDto
    {
        public string Regnumber { get; set; }
        public string SecurityAnswer { get; set; }
    }
}