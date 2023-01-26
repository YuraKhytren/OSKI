using ArtSoftAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ArtSoftAPI.Data
{
    public class AppContext : DbContext
    {
        public AppContext() : base()
        {
        }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
     
        }
        
        public DbSet<Test> Tests { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

    }


}
