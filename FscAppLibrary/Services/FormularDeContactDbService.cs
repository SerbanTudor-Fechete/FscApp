namespace FscAppLibrary.Services
{
    public class FormularDeContactDbService : MainDbService
    {
        public FormularDeContactDbService(IDbContextFactory<DataBaseContext> dbContextFactory) : base(dbContextFactory)
        {
        }
        public void AddFormular(FormularDeContactModel formular)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Formulare.Add(formular);
            context.SaveChanges();
        }
    }
}
