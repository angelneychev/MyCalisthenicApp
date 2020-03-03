﻿namespace MyCalisthenicApp.Web.Middlewares
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using MyCalisthenicApp.Models;
    using MyCalisthenicApp.Models.ShopEntities;
    using MyCalisthenicApp.Web.Common;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedRolesMiddleware
    {
        private readonly RequestDelegate next;


        public SeedRolesMiddleware(RequestDelegate next)
        {
            this.next = next;

        }

        public async Task InvokeAsync(
            HttpContext httpContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)

        {
            SeedUserInRoles(userManager, roleManager)
                 .GetAwaiter()
                 .GetResult();

            await this.next(httpContext);
        }


        private static async Task SeedUserInRoles(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = GlobalConstants.AdministratorFirstName,
                    LastName = GlobalConstants.AdministratorLastName,
                    UserName = GlobalConstants.AdministratorEmail,
                    Email = GlobalConstants.AdministratorEmail,
                    ShoppingCart = new ShoppingCart
                    {
                        Id = Guid.NewGuid().ToString(),
                        CardNumber = GlobalConstants.AdministratorCardNumber,
                        CVV = GlobalConstants.AdministratorCardCVV
                    },

                };

                var role = await roleManager.CreateAsync(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = GlobalConstants.AdministratorRoleName
                });


                var result = await userManager.CreateAsync(user, GlobalConstants.AdministratorPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);

                }

            }
        }
    }
}