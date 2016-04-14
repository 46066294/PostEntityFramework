using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Configuration
{
    class UserConfiguration :System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            
        {
            this.Property(c => c.Description).IsRequired();
        }
    }
}
