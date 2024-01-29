using ProvaPub.Enums;
using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class PaymentPaypal : OrderServicePayment
    {
       
        public override async Task<Order> PayOrder(PaymentMethod paymentMethod, 
            decimal paymentValue, 
            int customerId)
        {
            return await Task.FromResult(new Order()
            {
                Value = paymentValue,
                CustomerId = customerId
            });;
        }
    }
}
