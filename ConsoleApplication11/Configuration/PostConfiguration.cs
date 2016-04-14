using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Configuration
{
    class PostConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
           
        {
            this.Property(c => c.Description).IsRequired();
            this.HasMany(c => c.Comments).WithRequired().WillCascadeOnDelete();
            this.HasMany(c => c.Tags).WithRequired().WillCascadeOnDelete();
        }
    }
}
