using Microsoft.EntityFrameworkCore;

namespace Portfolio.API
{

    // CLASSE DE ENTITY FRAMEWORK ABLES TO SERVICES! \/ 
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options)
        {

        }

        // entity fmwk \/ dbset <contatos lista> = contatos, pegue, override configuring ables data!
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}
