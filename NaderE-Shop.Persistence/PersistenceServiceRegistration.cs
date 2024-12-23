using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Persistence.Repositories;

namespace NaderE_Shop.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServis(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ShopDbConnection");
            services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(ICommentRepository), typeof(CommentAttribute));
            services.AddScoped(typeof(ICustomFormatter), typeof(CustomerRepository));
            services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(IShoppingCartRepository), typeof(ShoppingCartRepository));
            services.AddScoped(typeof(IShopUserRepository), typeof(ShopUserRepository));

            return services;
        }
    }
}
