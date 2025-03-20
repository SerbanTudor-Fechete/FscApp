namespace FscAppLibrary.DataAccess
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<FormularDeContactModel> Formulare { get; set; }
        public DbSet<ProgramareOnlineModel> Programari { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }

    }
}
