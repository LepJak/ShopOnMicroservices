using CatalogService.Core.Application.Interfaces;
using CatalogService.Core.Domain;
using MediatR;

namespace CatalogService.Core.Application.Commands.CreateCatalogItem
{
    public class CreateCatalogItemCommandHandler : IRequestHandler<CreateCatalogItemCommand, Guid>
    {
        private readonly ICatalogContext _catalogContext;
        public CreateCatalogItemCommandHandler(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }
        
        public async Task<Guid> Handle(CreateCatalogItemCommand request, CancellationToken cancellationToken)
        {
            var ctalogItem = new CatalogItem()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                Created = DateTime.UtcNow,
            };
            await _catalogContext.CatalogItems.AddAsync(ctalogItem, cancellationToken);

            return ctalogItem.Id;
        }
    }
}
