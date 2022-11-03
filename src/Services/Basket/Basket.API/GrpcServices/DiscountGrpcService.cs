using Discount.Grpc.Protos;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {

        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoClient;


        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoClient)
        {
            _discountProtoClient = discountProtoClient;
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };
            return await _discountProtoClient.GetDiscountAsync(discountRequest);
        }
    }
}
