using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VocaBuilder.Core;
using VocaBuilder.Data;
using VocaBuilder.Utility;

namespace VocaBuilder
{
    public class DatabaseSeeder
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                var _roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
                var _userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                using (var context = new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
                {

                    if (await _roleManager.FindByNameAsync(AppConstant.AdminRole) == null)
                    {
                        string superAdminEmail = "bakareisrael@gmail.com";
                        string superAdminPassword = "Abc123*";

                        await _roleManager.CreateAsync(new ApplicationRole(AppConstant.AdminRole));
                        var user = new ApplicationUser { UserName = superAdminEmail, Email = superAdminEmail };
                        var result = await _userManager.CreateAsync(user, superAdminPassword);
                        if (!result.Succeeded)
                            throw new Exception();
                        await _userManager.AddToRoleAsync(user, AppConstant.AdminRole);

                    }

                    if (await _roleManager.FindByNameAsync(AppConstant.UserRole) == null)
                        await _roleManager.CreateAsync(new ApplicationRole(AppConstant.UserRole));

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
