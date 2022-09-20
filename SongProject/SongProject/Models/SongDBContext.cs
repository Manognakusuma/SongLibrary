using System.Data.Entity;
namespace SongProject.Models
{
    public class SongDBContext : DbContext
    {
        public SongDBContext() : base("SongDBConn")
        {


        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<UserAccount> Users { get; set; }
    }
}