namespace jwt_authentication_api.Configurations
{
    public static class CorsConfig
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Development", builder => builder
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithOrigins("https://localhost:7245")
                       .AllowCredentials());

                options.AddPolicy("Production", builder => builder
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithOrigins("https://localhost:7245")
                       .AllowCredentials());
            });

            return builder;
        }
    }
}