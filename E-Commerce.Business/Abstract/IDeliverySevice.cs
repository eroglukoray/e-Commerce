using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface IDeliveryService
    {
        List<Deliveries> getDeliveries();
        Deliveries getDeliveryByCartId(int cartId);
        void createDelivery(Deliveries deliveries);

        DeliveryInfo calculateFor(CartProducts carts);
      
    }
}
