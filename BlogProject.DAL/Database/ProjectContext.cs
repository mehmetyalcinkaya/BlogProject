using BlogProject.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BlogProject.DAL.Mappings;

namespace BlogProject.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            : base("defaultConnection")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance; //TODO TERRIBLE HACK DIYE GECIYOR
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AboutPageMappings());
            modelBuilder.Configurations.Add(new ContactPageMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }
    }
}
