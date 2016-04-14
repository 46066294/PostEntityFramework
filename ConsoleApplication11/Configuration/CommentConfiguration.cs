using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11.Configuration
{
    class CommentConfiguration :System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Comment>
    {
        public CommentConfiguration()
            
        {
            this.Property(c => c.Description).IsRequired();
            this.HasRequired(c => c.User);
        }
    }
}
