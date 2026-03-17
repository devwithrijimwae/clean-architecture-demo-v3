using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.product.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<Domain.Entities.Product>>
    {
        internal class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Domain.Entities.Product>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllProductQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Domain.Entities.Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var result = await _context.Products.ToListAsync(cancellationToken);
                return result;
            }
        }
    }
}