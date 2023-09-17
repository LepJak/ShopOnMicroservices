using CatalogService.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Core.Application.Interfaces
{
    public interface ICatalogContext
    {
        DbSet<CatalogItem> CatalogItems { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
