using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlServer(@"Data Source=C:\blogging.db");
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}