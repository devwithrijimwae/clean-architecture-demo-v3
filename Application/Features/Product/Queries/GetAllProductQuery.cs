using MediatR;

namespace Application.Features.Product.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<Product>>
    {
        internal class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Product>>
        {

            public async Task<IEnumerable<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var list = new List<Product>();
                for (int i = 0; i < 100; i++)
                {
                    var prod = new Product();
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
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Rate { get; set; }
        }
}