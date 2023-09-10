namespace FscAppLibrary.Services
{
    public class ComentariuDbService : MainDbService
    {
        public ComentariuDbService(IDbContextFactory<DataBaseContext> dbContextFactory) : base(dbContextFactory)
        {
        }
        public void AddComentariu(ComentariuModel comentariu)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Comentarii.Add(comentariu);
            context.SaveChanges();
        }
    }
}
