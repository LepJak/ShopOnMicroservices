using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CatalogService.Infrastructure.DataContext
{
    public class CatalogDbInitialyzer
    {
        public static void Initialize(CatalogDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
