using Hrssu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos.Api
{
    public class ApiSessionList
    {
        public int Id { get; set; }
        public string FullSession { get; set; }
        public SessionStatus SessionStatus { get; set; }
        public string Session { get; set; }
        public string Term { get; set; }
    }
}