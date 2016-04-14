using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Configuration
{
    class TagConfiguration :System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
            
        {
            this.Property(c => c.Description).IsRequired();
        }
    }
}
