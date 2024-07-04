using Demo.Infra.Repository.Context;

namespace Demo.Api.Configuration
{
    public static class DbConfiguration
    {
        public static IServiceCollection AddDbConfiguration(this IServiceCollection services, IConfiguration config)
        {
            var connString = config.GetConnectionString("MongoDB");

            services.AddEntityFrameworkMongoDB();
            services.AddMongoDB<DemoDBContext>(connString, "my_sample_db");

            return services;
        }
    }
}
