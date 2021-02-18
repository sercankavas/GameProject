using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OfferManager : IOfferService
    {

        public void AddOffer(Offer offer)
        {
            Console.WriteLine("Offer is added");
        }

        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine("Offer is deleted");
        }

        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine("Offer is updated");
        }
    }
}
