using MediatR;

namespace CatalogService.Core.Application.Commands.CreateCatalogItem
{
    public class CreateCatalogItemCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
