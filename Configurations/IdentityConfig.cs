using jwt_authentication_api.Data;
using Microsoft.AspNetCore.Identity;

namespace jwt_authentication_api.Configurations
{
    public static class IdentityConfig
    {
        public static WebApplicationBuilder AddIdentityConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                            .AddRoles<IdentityRole>()
                            .AddEntityFrameworkStores<ApplicationDbContext>();

            return builder;
        }
    }
}