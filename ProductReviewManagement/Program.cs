﻿using System;
using System.Collections.Generic;
using System.Data;

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
                new ProductReview() { productID = 3, UserID = 2, Rating = 8, Review = "Good", isLike = true },
                new ProductReview() { productID = 3, UserID = 3, Rating = 2, Review = "Bad", isLike = true },
                new ProductReview() { productID = 4, UserID = 1, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { productID = 5, UserID = 1, Rating = 2, Review = "nice", isLike = true },
                new ProductReview() { productID = 6, UserID = 1, Rating = 1, Review = "bad", isLike = true },
                new ProductReview() { productID = 7, UserID = 1, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { productID = 7, UserID = 2, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { productID = 7, UserID = 3, Rating = 3, Review = "Good", isLike = false },
                new ProductReview() { productID = 8, UserID = 1, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { productID = 9, UserID = 1, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { productID = 10, UserID = 1, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { productID = 11, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { productID = 7, UserID = 10, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { productID = 7, UserID = 10, Rating = 3, Review = "Good", isLike = false },
                new ProductReview() { productID = 3, UserID = 10, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { productID = 2, UserID = 10, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { productID = 8, UserID = 10, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { productID = 11, UserID = 10, Rating = 3, Review = "nice", isLike = true }
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
            //UC5 Retrieve only product id and review for all products
            Console.WriteLine("=========================================================================================");
            management.RetrieveProductIDAndReview(productReviewList);
            //UC6 Skip top 5 records and display other records
            Console.WriteLine("=========================================================================================");
            management.SkipTopRecords(productReviewList);
            //UC8 Insert records into data table
            Console.WriteLine("=========================================================================================");
            DataTable dataTable = management.InsertRecordsInDataTable(productReviewList);
            //UC9 Retrieve Data from datatable where islike = true
            Console.WriteLine("=========================================================================================");
            management.RetrieveDataWhenIsLikeTrue(dataTable);
            //UC10 Retrieve Average rating for each product
            Console.WriteLine("=========================================================================================");
            management.AverageRatingOfEachProduct(dataTable);
            //UC11 Retrieve records having review as nice
            Console.WriteLine("=========================================================================================");
            management.RetrieveRecordsHavingReviewNice(dataTable);
            //UC12 Retrieve records having user id 10
            Console.WriteLine("=========================================================================================");
            management.RetrieveRecordsOfParticualrUserId(dataTable, 10);
        }
    }
}
