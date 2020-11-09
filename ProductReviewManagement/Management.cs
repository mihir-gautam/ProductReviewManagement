using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class Management
    {
        /// <summary>
        /// UC2 Method to retrieve top 3 records having best rating.
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.productID + " " + "UserID:-"
                    + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
        /// <summary>
        /// UC3  Method to Retrieve products having rating > 3 and product id 1,4,9 only
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.productID == 1 || productReviews.productID == 4 || productReviews.productID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.productID + " " + "UserID:-"
                    + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
        /// <summary>
        /// UC4 Method to retrieve count of product reviews for each product
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.productID).Select(x => new { productID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.productID + "-----------" + list.Count);
            }
        }
        /// <summary>
        /// UC5 Method to retrieve product id and review for all the products
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveProductIDAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                select new { productReviews.productID,productReviews.Review});
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.productID + " Review:- " + list.Review);
            }
        }
        /// <summary>
        /// UC6 Method to skip top 5 records and then retrieve rest of the records
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SkipTopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                select productReviews).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.productID + " " + "UserID:-"
                    + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
        /// <summary>
        /// UC8 Add new records to the Data Table
        /// </summary>
        /// <param name="listProductReview"></param>
        public readonly DataTable dataTable = new DataTable();
        public void InsertRecordsInDataTable(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));

            foreach (ProductReview productReviews in listProductReview)
            {
                dataTable.Rows.Add(productReviews.productID, productReviews.UserID, productReviews.Rating, productReviews.Review, productReviews.isLike);
            }
            Console.WriteLine("Records added into data table succesfully");
        }
        public void RetrieveRecordsOfParticualrUserId(List<ProductReview> listProductReview, int userId)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.UserID == userId)
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.productID + " " + "UserID:-"
                    + list.UserID + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
    }
}
