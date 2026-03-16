using MediatR;

namespace Application.Features.Product.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //logic
                return 1;
            }
        }
    }
}
