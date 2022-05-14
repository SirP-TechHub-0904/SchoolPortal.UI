using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class PinInfoDto
    {
        public int Id { get; set; }

        public string PinNumber { get; set; }

        public string SerialNumber { get; set; }

        public int Usage { get; set; }

        public string SessionUsed { get; set; }

        public string BatchNumber { get; set; }

        public string StudentPin { get; set; }
        public string StudentFullName { get; set; }


    }
}