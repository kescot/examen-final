public class ApplicationDbContext : DbContext {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       public DbSet<Client> Clients { get; set; }
       public DbSet<ClientInfo> ClientInfos { get; set; }
   }