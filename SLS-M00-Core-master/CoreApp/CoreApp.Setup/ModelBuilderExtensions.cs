using CoreApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Setup
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role { RoleId = 1, DisplayValue = "Admin", IsActive = true, CreatedBy = "Seed", CreatedDate = DateTime.Now, UpdatedBy = "Seed", UpdatedDate = DateTime.Now},
                    new Role { RoleId = 2, DisplayValue = "Client", IsActive = true, CreatedBy = "Seed", CreatedDate = DateTime.Now, UpdatedBy = "Seed", UpdatedDate = DateTime.Now },
                    new Role { RoleId = 3, DisplayValue = "Manager", IsActive = true, CreatedBy = "Seed", CreatedDate = DateTime.Now, UpdatedBy = "Seed", UpdatedDate = DateTime.Now }
                );
        }
    }
}
