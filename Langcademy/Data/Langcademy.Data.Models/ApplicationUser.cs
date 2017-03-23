namespace Langcademy.Data.Models
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Common.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.ComponentModel.DataAnnotations;
    using Langcademy.Common;
    using System.Collections.Generic;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser, IDeletableEntity, IAuditInfo
    {
        private ICollection<Topic> createdTopics;
        private IList<TopicSubmission> submissions;

        public ApplicationUser()
        {
            this.Level = GlobalConstants.InitialLevel;
            this.submissions = new List<TopicSubmission>();
            this.createdTopics = new HashSet<Topic>();

            // TODO: maybe UtcNow, but left it like this for consistency with other code
            this.CreatedOn = DateTime.Now;
        }

        [Required]
        [MaxLength(GlobalConstants.FirstNameMaxLength)]
        [MinLength(GlobalConstants.FirstNameMinLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(GlobalConstants.LastNameMaxLength)]
        [MinLength(GlobalConstants.LastNameMinLength)]
        public string LastName { get; set; }

        [MaxLength(GlobalConstants.AvatarImageUrlMaxLength)]
        public string AvatarImageUrl { get; set; }

        public int Level { get; set; }

        public virtual ICollection<Topic> CreatedTopics
        {
            get { return this.createdTopics; }
            set { this.createdTopics = value; }
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual IList<TopicSubmission> Submissions
        {
            get { return this.submissions; }

            set { this.submissions = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
