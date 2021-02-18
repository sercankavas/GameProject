using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {

        IOfferService _offerService;

        public OrderManager(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public void SalesWithOffer(Order order)
        {

            Console.WriteLine("The sales is with out offer");

        }

        public void SalesWithoutOffer(Order order)
        {
            Console.WriteLine("The sales is with out offer");
        }
    }
}
