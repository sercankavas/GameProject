using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOfferService
    {
        void AddOffer(Offer offer);
        void DeleteOffer(Offer offer);
        void UpdateOffer(Offer offer);

    }
}
