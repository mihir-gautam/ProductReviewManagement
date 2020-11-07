using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program!");
            List<ProductReview> productReviewList = new List<ProductReview>()
            
            {
                new ProductReview() { productID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { productID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { productID = 3, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { productID = 4, UserID = 1, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { productID = 5, UserID = 1, Rating = 2, Review = "nice", isLike = true },
                new ProductReview() { productID = 6, UserID = 1, Rating = 1, Review = "bad", isLike = true },
                new ProductReview() { productID = 7, UserID = 1, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { productID = 8, UserID = 1, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { productID = 9, UserID = 1, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { productID = 10, UserID = 1, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { productID = 11, UserID = 1, Rating = 3, Review = "nice", isLike = true }
            };
            Management management = new Management();
            //UC2 Retrieve top 3 records by their rating
            management.TopRecords(productReviewList);
            //UC3 Retrieve selected record
            Console.WriteLine("=========================================================================================");
            management.SelectRecords(productReviewList);
            //UC4 Count of product reviews for each product id
            Console.WriteLine("=========================================================================================");
            management.RetrieveCountOfRecords(productReviewList);
        }
    }
}
