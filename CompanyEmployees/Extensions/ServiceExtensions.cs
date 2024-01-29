namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyHeader());
            });

        public static void ConfiureISSIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => { });
    }
}