using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class ApprovedDevice
    {
        public int Id { get; set; }
        public string MacAddress { get; set; }
        public string ImelNumber { get; set; }
        public string IpAddress { get; set; }
        public string Date { get; set; }
        public string DeviceThatAddedThis { get; set; }
    }
}