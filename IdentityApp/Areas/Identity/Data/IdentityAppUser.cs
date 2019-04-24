using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Areas.Identity.Data
{
    public class IdentityAppUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        //public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        //public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        //public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        //public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
    }

    //public class ApplicationRole : IdentityRole
    //{
    //    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    //    public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    //}

    //public class ApplicationUserRole : IdentityUserRole<string>
    //{
    //    public virtual IdentityAppUser User { get; set; }
    //    public virtual ApplicationRole Role { get; set; }
    //}

    //public class ApplicationUserClaim : IdentityUserClaim<string>
    //{
    //    public virtual IdentityAppUser User { get; set; }
    //}

    //public class ApplicationUserLogin : IdentityUserLogin<string>
    //{
    //    public virtual IdentityAppUser User { get; set; }
    //}

    //public class ApplicationRoleClaim : IdentityRoleClaim<string>
    //{
    //    public virtual ApplicationRole Role { get; set; }
    //}

    //public class ApplicationUserToken : IdentityUserToken<string>
    //{
    //    public virtual IdentityAppUser User { get; set; }
    //}
}