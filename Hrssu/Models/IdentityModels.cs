﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Hrssu.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System;

namespace Hrssu.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string Surname { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Other Name")]
        public string OtherName { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateRegistered { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime? DataStatusChanged { get; set; }

        public string Religion { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Contact Address")]
        public string ContactAddress { get; set; }
        public string City { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Local Government Area")]
        public string LocalGov { get; set; }

        [Display(Name = "State Of Origin")]
        public string StateOfOrigin { get; set; }

        public string Nationality { get; set; }
        public string RegisteredBy { get; set; }
        public bool? IsLocked { get; set; }
    }
    //public class PortalContext : DbContext
    //{
    //    public PortalContext()
    //      : base("PortalSchools")
    //    {
    //    }
    //    public DbSet<Schools> Schools { get; set; }
    //}

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public DbSet<ClassLevel> ClassLevels { get; set; }
        public DbSet<EnrolledSubject> EnrolledSubjects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<PinCodeModel> PinCodeModels { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<LocalGovs> LocalGovs { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<StaffProfile> StaffProfiles { get; set; }
        public DbSet<PublishResult> PublishResults { get; set; }
        public DbSet<ImageModel> ImageModel { get; set; }
        public DbSet<Defaulter> Defaulters { get; set; }
        public DbSet<SmsReport> SmsReports { get; set; }
        public DbSet<SmsGroup> SmsGroups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<MessageReply> MessageReply { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<HallOfFame> HallOfFames { get; set; }
        public DbSet<ImageSlider> ImageSlider { get; set; }
        public DbSet<StudentData> StudentDatas { get; set; }
        public DbSet<Grading> Gradings { get; set; }
        public DbSet<GradingDetails> GradingDetails { get; set; }
        public DbSet<Syllable> syllables { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Riddles> Riddles { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<AssignmentAnswer> AssignmentAnswers { get; set; }
        public DbSet<AttendanceDetail> AttendanceDetails { get; set; }
        public DbSet<BatchResult> BatchResults { get; set; }
        public DbSet<RecognitiveDomain> RecognitiveDomains { get; set; }
        public DbSet<PsychomotorDomain> PsychomotorDomains { get; set; }
        public DbSet<AffectiveDomain> AffectiveDomains { get; set; }
        public DbSet<SchoolFees> SchoolFees { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SchoolAccount> SchoolAccounts { get; set; }
        public DbSet<WebsiteSettings> WebsiteSettings { get; set; }
        public DbSet<ImageGallery> ImageGallery { get; set; }
        public DbSet<ContentPage> ContentPages { get; set; }
        public DbSet<CategoryPage> CategoryPages { get; set; }
        public DbSet<ContentImage> ContentImages { get; set; }
        public DbSet<Help> Helps { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<WebsiteColor> WebsiteColors { get; set; }
        public DbSet<SettingsValue> SettingsValues { get; set; }
        public DbSet<Finance> Finances { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<ApprovedDevice> ApprovedDevices { get; set; }
        public static ApplicationDbContext Create()


        {
            return new ApplicationDbContext();
        }

    }
}