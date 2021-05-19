using Factory_Pattern.Models.Commerce;
using Factory_Pattern.Models.Shipping;
using Factory_Pattern_First_Look.Business.Models.Shipping;
using System;

namespace Factory_Pattern
{
    public class ShoppingCart
    {
        private readonly Order order;

        public ShoppingCart(Order order)
        {
            this.order = order;
        }

        public string Finalize()    
        {
            #region Create Shipping Provider
            ShippingProvider shippingProvider;

            shippingProvider = ShippingProviderFactory.CreateShippingProvider(order.Sender.Country);
            #endregion

            order.ShippingStatus = ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);
        }
    }
}
