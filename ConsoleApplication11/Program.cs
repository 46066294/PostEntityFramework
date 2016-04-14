using ConsoleApplication11.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

           

           

            using ( var ctx= new ContextBlog())
            {
              
                var post = new Post()
                {
                    Description ="Que poco se de c#, porque será",
                    
                };
                post.Tags.Add(new Tag() { Description="c#"});
                post.Comments.Add(new Comment()
                {
                    Description = "Pues si que se",
                    User = new User() { Description = "Pedro"}
                });
                ctx.Post.Add(post);
                
                ctx.SaveChanges();

                   
            }
            
            
           
        }
       
       
    }

    public class EntityBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
    public class Post :EntityBase
    {
        public Post()
        {
            Comments = new List<Comment>();
            Tags = new List<Tag>();
        }
     
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
    public class User : EntityBase
    {
      
    }
    public class Comment : EntityBase
    {       
        public  User User { get; set; }
    }
    public class Tag : EntityBase
    {
      

    }

   
    public class ContextBlog : DbContext
    {
        public ContextBlog()
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public IDbSet<Post> Post {get;set;}
        public DbSet<User> User { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Configurations.Add(new CommentConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
