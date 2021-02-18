using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void SalesWithOffer(Order order);

        void SalesWithoutOffer(Order order);
    }
}
