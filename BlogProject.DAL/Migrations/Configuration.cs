using BlogProject.Entities;

namespace BlogProject.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogProject.DAL.Database.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogProject.DAL.Database.ProjectContext context)
        {
            if (!context.AboutPage.Any())
            {
                var aboutpage = new AboutPage
                {
                    TitleName = "�rnek ba�l�k",
                    AboutDesc = "Seed ile gelen i�erik bu �ekilde kullan�lmal�d�r."
                };
                context.AboutPage.Add(aboutpage);
                context.SaveChanges();
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
