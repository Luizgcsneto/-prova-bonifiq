using ProvaPub.Enums;
using ProvaPub.Models;

namespace ProvaPub.Services
{
    public abstract class OrderServicePayment
    {
        public abstract Task<Order> PayOrder(PaymentMethod paymentMethod, decimal paymentValue, int customerId);
    }

}








