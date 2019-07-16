using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MvcEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcEfCore.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                //context.Database.EnsureCreated();
                //context.Database.Migrate();C:\Users\May NG\Desktop\AirTicketMVC-master\MvcEfCore\Data\DummyData.cs

                // Look for any teams.
                if (context.SanBays.Any())
                {
                    return;   // DB has already been seeded
                }

                var sanbays = DummyData.GetSanBays().ToArray();
                context.SanBays.AddRange(sanbays);
                context.SaveChanges();
                //var players = DummyData.GetHangVe(context).ToArray();
                //context.Players.AddRange(players);
                //context.SaveChanges();
                //var sanBays = DummyData.GetSanBays().ToArray();
                //context.SanBays.AddRange(sanBays);
                var hangVes = DummyData.GetHangVe().ToArray();
                context.HangVes.AddRange(hangVes);
                context.SaveChanges();
            }
        }

        
        public static List<SanBay> GetSanBays()
        {

            List<SanBay> sanBays = new List<SanBay>() {
            new SanBay {
                SanBayId = "SBHCM",
                TenSanBay = "Tan Son Nhat"},
            new SanBay {
                SanBayId = "SBKH",
                TenSanBay = "Cam Ranh"},
            new SanBay {
                SanBayId = "SBHN",
                TenSanBay = "Noi Bai"}
                };
            return sanBays;
        }
        public static List<HangVe> GetHangVe()
        {

            List<HangVe> hangVes = new List<HangVe>() {
            new HangVe {
                HangID = "HA01",
                TenHang = "Hạng 1",
            TiLeGia = 100},
            new HangVe {
                HangID = "HA02",
                TenHang = "Hạng 2",TiLeGia = 50},
                };
            return hangVes;
        }
        //    public static List<Player> GetPlayers(ApplicationDbContext context)
        //    {
        //        List<Player> players = new List<Player>() {
        //        new Player {
        //            FirstName = "Sven",
        //            LastName = "Baertschi",
        //            TeamName = context.Teams.Find("Canucks").TeamName,
        //            Position = "Forward"
        //        },
        //        new Player {
        //            FirstName = "Hendrik",
        //            LastName = "Sedin",
        //            TeamName = context.Teams.Find("Canucks").TeamName,
        //            Position = "Left Wing"
        //        },
        //        new Player {
        //            FirstName = "John",
        //            LastName = "Rooster",
        //            TeamName = context.Teams.Find("Flames").TeamName,
        //            Position = "Right Wing"
        //        },
        //        new Player {
        //            FirstName = "Bob",
        //            LastName = "Plumber",
        //            TeamName = context.Teams.Find("Oilers").TeamName,
        //            Position = "Defense"
        //        },
        //    };

        //        return players;
        //    }

        //    public static List<Team> ProcessImport(string path)
        //    {
        //        XDocument xDocument = XDocument.Load(path);
        //        List<Team> teams = xDocument.Descendants("team").Select
        //            (p => new Team()
        //            {
        //                TeamName = p.Element("TeamName").Value,
        //                City = p.Element("City").Value,
        //                Province = p.Element("Province").Value,
        //                Country = p.Element("Country").Value
        //            }).ToList();
        //        return teams;
        //    }
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
    }

    
}
