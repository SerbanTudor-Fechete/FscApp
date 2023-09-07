using Microsoft.EntityFrameworkCore;


namespace FscAppUi
{
    public static class RegisterServices
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("SqlServer");

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddMemoryCache();
            builder.Services.AddDbContextFactory<DataBaseContext>((DbContextOptionsBuilder options) =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
