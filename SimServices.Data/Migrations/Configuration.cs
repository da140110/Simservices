namespace SimServices.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SimServices.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SimServices.Data.SimServicesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimServices.Data.SimServicesDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new SimServicesDbContext())) ;
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new SimServicesDbContext()));
            var user = new ApplicationUser()
            {
                UserName = "dtlinh",
                Email = "daotuanlinh@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Đào Tuấn Linh"
            };
            manager.Create(user, "123456");
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new ApplicationRole { Name = "Admin" });
                roleManager.Create(new ApplicationRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("daotuanlinh@gmail.com");
            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
