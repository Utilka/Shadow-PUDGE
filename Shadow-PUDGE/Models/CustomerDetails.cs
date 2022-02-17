using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_PUDGE.Models
{
    public class CustomerDetails
    {
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<CustomerUser> manager)
        //{
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //    // Add custom user claims here
        //    return userIdentity;
        //}

        //Extended Properties
        public DateTime? BirthDate { get; set; }
        public long? OrganizationId { get; set; }

        //Key Mappings
        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
    }
}
