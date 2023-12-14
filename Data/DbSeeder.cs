using Demo.constants;
using Demo.Data;
using Microsoft.AspNetCore.Identity;
using System;

namespace Demo.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Store_Owner.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            // creating admin

            var admin = new ApplicationUser
            {
                UserName = "Admin1@gmail.com",
                Email = "Admin1@gmail.com",
                Name = "Admin1",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(admin.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(admin, "Dino520.");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }

            //Creating Store_Owner
            var user1 = new ApplicationUser
            {
                UserName = "Dino@gmail.com",
                Email = "Dino@gmail.com",
                Name = "Ryan Connor",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb1 = await userManager.FindByEmailAsync(user1.Email);
            if (userInDb1 == null)
            {
                await userManager.CreateAsync(user1, "Dino520.");
                await userManager.AddToRoleAsync(user1, Roles.Store_Owner.ToString());
            }
        }

    }
}
