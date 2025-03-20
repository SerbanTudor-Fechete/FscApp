namespace FscAppLibrary.Services
{
    public class MainDbService
    {
        public IDbContextFactory<DataBaseContext> _dbContextFactory;

        public MainDbService(IDbContextFactory<DataBaseContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
    }
}
