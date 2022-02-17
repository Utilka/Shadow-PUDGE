using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Shadow_PUDGE.Models
{
    public class CustomerDetails : IdentityUser
    {

        public int FullName { get; set; }
        public int Adress { get; set; }
        public int Phone { get; set; }
        public DateTime RegisterDate { get; set; }

        
    }
}
