using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Syncfusion.Blazor;

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
            builder.Services.AddSyncfusionBlazor();

            builder.Services.AddDbContextFactory<DataBaseContext>((DbContextOptionsBuilder options) =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddTransient<FormularDeContactDbService>();
            builder.Services.AddTransient<ProgramareOnlineDbService>();
            builder.Services.AddTransient<ReviewDbService>();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cXGFCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWXZfd3RRQ2leWUZ0WEA=");
        }
    }
}
