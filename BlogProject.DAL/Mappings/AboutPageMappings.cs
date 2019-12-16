using System.Data.Entity.ModelConfiguration;
using BlogProject.Entities;

namespace BlogProject.DAL.Mappings
{
    public class AboutPageMappings : EntityTypeConfiguration<AboutPage>
    {
        public AboutPageMappings()
        {
            ToTable("About", "blog");
        }
    }
}
