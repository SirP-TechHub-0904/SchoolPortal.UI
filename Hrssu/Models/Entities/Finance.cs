using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Entities
{
    public class Finance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        [Display(Name = "Admin Note")]

        public string AdminNote { get; set; }
        public string Description { get; set; }
        [Display(Name = "Finance Type")]

        public FinanceType FinanceType { get; set; }
        public decimal Amount { get; set; }
        [Display(Name = "Reference Id")]

        public string ReferenceId { get; set; }
        [Display(Name = "Finance Source")]

        public FinanceSource FinanceSource { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Registration Number")]

        public string RegistrationNumber { get; set; }
        public int? EnrolmentId { get; set; }

        public int? SessionId { get; set; }
        public Session Session { get; set; }
    }
}