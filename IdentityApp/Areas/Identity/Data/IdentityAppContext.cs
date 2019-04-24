using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Models
{
    public class IdentityAppContext 
        : IdentityDbContext<IdentityAppUser
            //, ApplicationRole, string,
            //ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
            //ApplicationRoleClaim, ApplicationUserToken
            >
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //{
            //    // Each User can have many UserClaims
            //    b.HasMany(e => e.Claims)
            //        .WithOne()
            //        .HasForeignKey(uc => uc.UserId)
            //        .IsRequired();
            
            //    b.HasMany(e => e.Logins)
            //        .WithOne()
            //        .HasForeignKey(ul => ul.UserId)
            //        .IsRequired();
            
            //    b.HasMany(e => e.Tokens)
            //        .WithOne()
            //        .HasForeignKey(ut => ut.UserId)
            //        .IsRequired();
            
            //    b.HasMany(e => e.UserRoles)
            //        .WithOne()
            //        .HasForeignKey(ur => ur.UserId)
            //        .IsRequired();
            //});

            //builder.Entity<ApplicationRole>(b =>
            //{
            //    b.HasMany(e => e.UserRoles)
            //        .WithOne(e => e.Role)
            //        .HasForeignKey(ur => ur.RoleId)
            //        .IsRequired();

            //    b.HasMany(e => e.RoleClaims)
            //        .WithOne(e => e.Role)
            //        .HasForeignKey(rc => rc.RoleId)
            //        .IsRequired();
            //});
        }
    }
}
