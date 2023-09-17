using CatalogService.Core.Application.Interfaces;
using CatalogService.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Infrastructure.DataContext
{
    public class CatalogDbContext : DbContext, ICatalogContext
    {
        public DbSet<CatalogItem> CatalogItems { get ; set; }
    }
}
