namespace TeduShop.Data.Migrations
{
    using Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "admin",
            //    Email = "khanhvinhit@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Khánh Vinh Sang"
            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("khanhvinhit@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategorySample(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Điện lạnh 2",Alias="dien-lanh",Status=true },
                 new ProductCategory() { Name="Viễn thông 2",Alias="vien-thong",Status=true },
                  new ProductCategory() { Name="Đồ gia dụng 2",Alias="do-gia-dung",Status=true },
                   new ProductCategory() { Name="Mỹ phẩm 2",Alias="my-pham",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }

        private void CreateFooter(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterID) == 0)
            {
                List<Footer> listFooterCategory = new List<Footer>()
            {
                new Footer() { ID="Điện lạnh 2",Content="dien-lanh"},
                 new Footer() { ID="Viễn thông 2",Content="vien-thong" },
                  new Footer() { ID="Đồ gia dụng 2",Content="do-gia-dung"},
                   new Footer() { ID="Mỹ phẩm 2",Content="my-pham"}
            };
                context.Footers.AddRange(listFooterCategory);
                context.SaveChanges();
            }
        }
    }
}