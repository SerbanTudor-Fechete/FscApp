namespace FscAppLibrary.Services
{
    public class ProgramareOnlineDbService : MainDbService
    {
        public ProgramareOnlineDbService(IDbContextFactory<DataBaseContext> dbContextFactory) : base(dbContextFactory)
        {
        }
        public void AddProgramare(ProgramareOnlineModel programare)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Programari.Add(programare);
            context.SaveChanges();
        }
    }
}
