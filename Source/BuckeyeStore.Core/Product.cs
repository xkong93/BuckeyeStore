﻿using System;
using System.Collections.Generic;

namespace BuckeyeStore.Core
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string Brand {get; set;}
        public Review Review {get; set;}
        public AggregateRating AggregateRating {get; set;}
        public List<Offer> Offers {get; set;}
        public string sku {get; set;}

        public void AddReview(Review review)
        {
            this.Review = review;
        }
    }
}