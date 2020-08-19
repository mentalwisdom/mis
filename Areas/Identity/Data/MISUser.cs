using System;

using Microsoft.AspNetCore.Identity;

namespace MIS.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the FpUser class
    public class MISUser : IdentityUser
    {

        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        [PersonalData]
        public string Role { get; set; }

        [PersonalData]
        public string mobile { get; set; }

        


    }
}
