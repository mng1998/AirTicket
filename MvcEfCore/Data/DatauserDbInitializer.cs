using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Data
{
    public class DatauserDbInitializer
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "HR" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName); if (!roleExist)
                {
                    //create the roles and seed them to the data base: Question 1                     
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            IdentityUser user = await UserManager.FindByEmailAsync("admin@gmail.com");
            if (user == null)
            {
                user = new IdentityUser() { UserName = "admin@gmail.com", Email = "admin@gmail.com", };
                await UserManager.CreateAsync(user, "Test@123");
            }
            await UserManager.AddToRoleAsync(user, "Admin");


            IdentityUser user1 = await UserManager.FindByEmailAsync("ttquynh@gmail.com");
            if (user1 == null)
            {
                user1 = new IdentityUser() { UserName = "ttquynh@gmail.com", Email = "ttquynh@gmail.com", };
                await UserManager.CreateAsync(user1, "Test@123");
            }
            await UserManager.AddToRoleAsync(user1, "User");
            IdentityUser user2 = await UserManager.FindByEmailAsync("ttquynh1@gmail.com");
            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "ttquynh1@gmail.com",
                    Email = "ttquynh1@gmail.com",
                }; await UserManager.CreateAsync(user2, "Test@123");
            }

            await UserManager.AddToRoleAsync(user2, "HR");
        }
        public static void Intialize(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
IConfiguration configuration)
        {
            context.SaveChanges();

        }
    }
}
