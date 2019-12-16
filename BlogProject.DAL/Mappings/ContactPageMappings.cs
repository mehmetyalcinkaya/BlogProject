using System.Data.Entity.ModelConfiguration;
using BlogProject.Entities;

namespace BlogProject.DAL.Mappings
{
    public class ContactPageMappings : EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");
        }
    }
}
