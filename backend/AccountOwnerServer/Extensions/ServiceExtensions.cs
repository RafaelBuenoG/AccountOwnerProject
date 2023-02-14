namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin() // WithOrigins("domínio")
                    .AllowAnyMethod() // WhithMethods("GET", "POST")
                    .AllowAnyHeader() // WithHeaders("accept", "content-type")
                );
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => {

            });
        }
    }
}