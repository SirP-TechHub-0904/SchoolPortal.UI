using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class BankDetails
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime Date { get; set; }
    }
}