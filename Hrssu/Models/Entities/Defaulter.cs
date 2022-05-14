using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class Defaulter
    {
        public int Id { get; set; }

        public string Reason { get; set; }

        public int ProfileId { get; set; }

        public StudentProfile StudentProfile { get; set; }
    }
}