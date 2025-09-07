using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;



namespace MyEcommerce.Infrastructure.DataAccess
{
    public class MyEcommerceDbContextFactory : IDesignTimeDbContextFactory<MyEcommerceDbContext>
    {
        public MyEcommerceDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder() 
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "MyEcommerce.Web"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<MyEcommerceDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new MyEcommerceDbContext(optionsBuilder.Options);
        }
    }
}
    