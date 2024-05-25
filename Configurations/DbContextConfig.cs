using jwt_authentication_api.Data;
using Microsoft.EntityFrameworkCore;

namespace jwt_authentication_api.Configurations
{
    public static class DbContextConfig
    {
        public static WebApplicationBuilder AddDbContextConfig(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                           options.UseSqlServer(connectionString));

            return builder;
        }
    }
}