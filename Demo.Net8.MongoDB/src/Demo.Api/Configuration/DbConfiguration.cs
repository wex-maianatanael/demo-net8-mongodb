using Demo.Infra.Repository.Context;

namespace Demo.Api.Configuration
{
    public static class DbConfiguration
    {
        public static IServiceCollection AddDbConfiguration(this IServiceCollection services, IConfiguration config)
        {
            var connString = config.GetConnectionString("MongoDB");

            services.AddEntityFrameworkMongoDB();

            // info: this way both database and collections (documents) weren't created if not existed.
            // todo: must implement options to use the methods GetCollection and GetDatabase to create them if not exists.
            // todo: we can possibly need to create some indexes too, this config method would be the right place to do it.
            services.AddMongoDB<DemoDBContext>(connString, "my_sample_db");

            return services;
        }
    }
}
