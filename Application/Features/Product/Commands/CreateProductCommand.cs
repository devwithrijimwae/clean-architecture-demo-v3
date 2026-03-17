using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public decimal Rate { get; set; }

        internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
               var product = _mapper.Map<Domain.Entities.Product>(request);

                //var product = new Domain.Entities.Product
                //{
                //    Name = request.Name,
                //    Description = request.Description,
                //    Rate = request.Rate
                //};

                await _context.Products.AddAsync(product, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return product.Id;
            }
        }
    }
}