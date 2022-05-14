using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hrssu.Models.Entities
{
    public class Setting
    {
        public Setting()
        {
            //Passmark = 50;
            PromotionByTrial = 0;
            ShowPositionOnResult = true;
            ShowCumulativeResultForThirdTerm = false;
            SslEnabled = false;
            ShowFeesOnResult = false;
            ShowAccctOnResult = false;
            AdmissionPinOption = AdmissionPinOption.UsedPin;
            PinValidOption = PinValidOption.Termly;

        }

        public int Id { get; set; }

        [Display(Name="School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "Short Name")]
        public string SchoolInitials { get; set; }

        [Display(Name = "School Address")]
        public string SchoolAddress { get; set; }

        [Display(Name = "School Address 2")]
        public string SchoolAddress2 { get; set; }

        [Display(Name = "State Located")]
        public string State { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Contact Mail")]
        public string ContactEmail { get; set; }

        [Display(Name = "Contact Phone Number")]
        public string ContactPhoneNumber { get; set; }

        public int ImageId { get; set; }


        //Sms Settings
        [Display(Name = "SMS Username")]
        public string SmsUsername { get; set; }

        [Display(Name = "SMS Password")]
        public string SmsPassword { get; set; }

        //Academic and Result Settings

        public decimal Passmark { get; set; }

        [Display(Name = "Promote All")]
        public bool PromoteAll { get; set; }

        [Display(Name = "Mark for Promotion on Trial")]
        public decimal PromotionByTrial { get; set; }

        [Display(Name = "Show Position on Result")]
        public bool ShowPositionOnResult { get; set; }

        [Display(Name = "Show School Fees on Result")]
        public bool ShowFeesOnResult { get; set; }

        [Display(Name = "Show School Account on Result")]
        public bool ShowAccctOnResult { get; set; }

        [Display(Name = "Show Cumulative Result for Third Term")]
        public bool ShowCumulativeResultForThirdTerm { get; set; }
        

        //Mail Settings
        [Display(Name = "Email")]
        public string EmailFrom { get; set; }

        [Display(Name = "Host")]
        public string MailHost { get; set; }

        public string Port { get; set; }

        [Display(Name = "Username")]
        public string MailUsername { get; set; }

        [Display(Name = "Password")]
        public string MailPassword { get; set; }

        [Display(Name = "SSL Enabled")]
        public bool SslEnabled { get; set; }

        [Display(Name = "Accessment Total Score")]
        public decimal AccessmentScore { get; set; }

        [Display(Name = "Exam Total Score")]
        public decimal ExamScore { get; set; }

        //admission screening settings

        [Display(Name = "Screening Venue")]
        public string ScreeningVenue { get; set; }

        [Display(Name = "Screening Time")]
        public string ScreeningTime { get; set; }

        [Display(Name = "Screening Date")]
        public string ScreeningDate { get; set; }

        [Display(Name = "Website Link")]
        public string WebsiteLink { get; set; }
        [Display(Name = "Portal Link")]
        public string PortalLink { get; set; }

        [Display(Name = "Is Primary and Nursery")]
        public bool IsPrimaryNursery { get; set; }


        [Display(Name = "Enable Batch Result Printing")]
        public bool EnableBatchResultPrinting { get; set; }

        [Display(Name = "Promotion By Maths And Eng")]
        public bool PromotionByMathsAndEng { get; set; }

        [Display(Name = "Default Enrollment Remark")]
        public string DefaultEnrollmentRemark { get; set; }

        [AllowHtml]
        public string GoogleAnalytics { get; set; }

        [UIHint("Enum")]
        public PrintOutOption PrintOutOption { get; set; }

        [UIHint("Enum")]
        public AdmissionPinOption AdmissionPinOption { get; set; }
        [AllowHtml]
        public string NewsletterContent { get; set; }
        public bool ShowNewsletterPage { get; set; }

        [UIHint("Enum")]
        public PinValidOption PinValidOption { get; set; }
    }
}
