using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Configuration
{
    class EntityBaseConfiguration :System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EntityBase>
    {
        public EntityBaseConfiguration()
        {
            this.Property(c => c.Description).IsRequired();
        }
    }
}
