using CQRS.CQRS.Queries.Request;
using CQRS.CQRS.Queries.Response;
using CQRS.Infrastructure.Context;

namespace CQRS.CQRS.Handlers.Query_Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly PsqlContext _psqlContext; 

        public GetProductByIdQueryHandler(PsqlContext psqlContext)
        {
               _psqlContext = psqlContext;
        }
        public GetProductByIdQueryResponse GetProductById(GetProductByIdQueryRequest getProductByIdQueryRequest) 
        {
            var product = _psqlContext.Products.FirstOrDefault(x => x.Id == getProductByIdQueryRequest.Id);
            return new GetProductByIdQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        } 
    }
}
