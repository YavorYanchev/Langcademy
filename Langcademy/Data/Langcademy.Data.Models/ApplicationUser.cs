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
        private ICollection<Topic> solvedTopics;

        public ApplicationUser()
        {
            this.createdTopics = new HashSet<Topic>();
            this.solvedTopics = new HashSet<Topic>();
            this.Level = GlobalConstants.InitialLevel;

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

        public virtual ICollection<Topic> SolvedTopics
        {
            get { return this.solvedTopics; }
            set { this.solvedTopics = value; }
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
