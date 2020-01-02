namespace Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.SamuraiShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Nó sẽ khởi tạo những dữ liệu mẫu khi tao khởi chạy ứng dụng
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(Data.SamuraiShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new SamuraiShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new SamuraiShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "ngocdung",
                Email = "dungduong.ftu2@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Duong Thi Ngoc Dung"
            };

            userManager.Create(user, "12345678");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = userManager.FindByEmail("dungduong.ftu2@gmail.com");

            userManager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
