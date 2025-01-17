﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcEfCore.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebEssentials.AspNetCore.Pwa;

namespace MvcEfCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                options.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //services.AddAuthorization(options => { options.AddPolicy("OnlyAdminAccess", policy => policy.RequireRole("Admin")); });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });
            services.AddProgressiveWebApp();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePagesWithReExecute("/Error/{0}");
            app.UseAuthentication();



            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                name: "area",
                template: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}");
            });

            CreateRoles(serviceProvider).Wait();
           
        }
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
          
            var RoleManager = serviceProvider.GetRequiredService
            <RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService
            <UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "HR" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            IdentityUser user = await UserManager.FindByEmailAsync("jignesh@gmail.com");
            if (user == null)
            {
                user = new IdentityUser()
                {
                    UserName = "jignesh@gmail.com",
                    Email = "jignesh@gmail.com",
                };
                await UserManager.CreateAsync(user, "Test@123");
            }
            await UserManager.AddToRoleAsync(user, "Admin");
            IdentityUser user1 = await UserManager.FindByEmailAsync("tejas@gmail.com");
            if (user1 == null)
            {

                user1 = new IdentityUser()
                {
                    UserName = "tejas@gmail.com",
                    Email = "tejas@gmail.com",
                };
                await UserManager.CreateAsync(user1, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user1, "User");
            IdentityUser user2 = await UserManager.FindByEmailAsync("rakesh@gmail.com");
            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "rakesh@gmail.com",
                    Email = "rakesh@gmail.com",
                };
                await UserManager.CreateAsync(user2, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user2, "HR");
        }
    }
}
