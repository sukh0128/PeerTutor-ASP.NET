using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeerTutor.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Major { get; set; }
        public string Year { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {


            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("name = PeerTutorDB", throwIfV1Schema: false)
        {
        }
       

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
    public partial class DBOModel : DbContext
    {
        public DBOModel() : base("name=PeerTutorDB")
        {
            Database.SetInitializer<DBOModel>(null);
        }

        
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }
        public virtual DbSet<Event> Events { get; set; }

    }

}