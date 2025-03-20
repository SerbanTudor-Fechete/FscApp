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
            var SyncfusionLicense = builder.Configuration.GetConnectionString("SyncfusionLicense");

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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SyncfusionLicense);
        }
    }
}
