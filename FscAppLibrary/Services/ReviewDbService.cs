namespace FscAppLibrary.Services
{
    public class ReviewDbService : MainDbService
    {
        public ReviewDbService(IDbContextFactory<DataBaseContext> dbContextFactory) : base(dbContextFactory)
        {
        }
        public void AddReview(ReviewModel review)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
