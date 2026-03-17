using MediatR;

namespace Application.Features.Product.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<Domain.Entities.Product>>
    {
        internal class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Domain.Entities.Product>>
        {

            public async Task<IEnumerable<Domain.Entities.Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var list = new List<Domain.Entities.Product>();
                for (int i = 0; i < 100; i++)
                {
                    var prod = new Domain.Entities.Product();
                    prod.Name = "Mobile";
                    prod.Description = "test Mobile";
                    prod.Rate = 100 +1;

                    list.Add(prod);
                }
                return list;
            }
        }
    }

        public class Product
        {
            public  string Name { get; set; }
            public  string Description { get; set; }
            public decimal Rate { get; set; }
        }
}