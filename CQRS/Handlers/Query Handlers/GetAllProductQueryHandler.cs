using CQRS.CQRS.Queries.Request;
using CQRS.CQRS.Queries.Response;
using CQRS.Infrastructure.Context;

namespace CQRS.CQRS.Handlers.Query_Handlers
{
    public class GetAllProductQueryHandler
    {
        private readonly PsqlContext _psqlContext;

        public GetAllProductQueryHandler(PsqlContext psqlContext)
        {
            _psqlContext = psqlContext;
        }

        public List<GetAllProductQueryResponse> GetAllProducts() 
        {
            return _psqlContext.Products.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            }).ToList<GetAllProductQueryResponse>();
        }
    }
}
