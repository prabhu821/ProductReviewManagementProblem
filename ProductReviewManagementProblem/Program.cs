﻿namespace ProductReviewManagementProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, userId = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 2, userId = 2, Rating = 2, Review = "Bad", IsLike = true },
                new ProductReview() { ProductId = 3, userId = 3, Rating = 3, Review = "Average", IsLike = false },
                new ProductReview() { ProductId = 4, userId = 4, Rating = 5, Review = "Excelent", IsLike = true },
                new ProductReview() { ProductId = 5, userId = 5, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 6, userId = 6, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 7, userId = 7, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 8, userId = 8, Rating = 5, Review = "Excelent", IsLike = false },
                new ProductReview() { ProductId = 9, userId = 9, Rating = 5, Review = "Excelent", IsLike = true },
                new ProductReview() { ProductId = 1, userId = 10, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 1, userId = 11, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductId = 2, userId = 12, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 3, userId = 13, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 4, userId = 14, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 5, userId = 15, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 6, userId = 16, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductId = 7, userId = 17, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 8, userId = 18, Rating = 3, Review = "Average", IsLike = false },
                new ProductReview() { ProductId = 9, userId = 19, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 2, userId = 20, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 1, userId = 21, Rating = 2, Review = "Bad", IsLike = true },
                new ProductReview() { ProductId = 2, userId = 22, Rating = 3, Review = "Average", IsLike = false },
                new ProductReview() { ProductId = 3, userId = 23, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 4, userId = 24, Rating = 5, Review = "Excelent", IsLike = false },
                new ProductReview() { ProductId = 5, userId = 25, Rating = 1, Review = "Worst", IsLike = true }
            };

            ProductReviewMain productReviewMain = new ProductReviewMain();
            DataTableLinq dataTableLinq = new DataTableLinq();
            dataTableLinq.AddDataTable();
            productReviewMain.AddProductList(productReviews);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option to Retrive \n1.Top 3 Records \n2.All Records \n3.All Records Group By " +
                    "\n4.All Records Fields \n5.Skip Top 5 Records \n6.All Records of ProductID and Review \n7.Display Table " +
                    "\n8.Retrieve IsLike Equals True \n9.Average Rating using ProductID \n10.Retrieve Using Review Message " +
                    "\n11.Retrieve Using UserID \n12.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        productReviewMain.RetriveTopRecords();
                        break;
                    case 2:
                        productReviewMain.RetriveAllRecords();
                        break;
                    case 3:
                        productReviewMain.RetriveAllRecordsGroupBy();
                        break;
                    case 4:
                        productReviewMain.RetriveAllRecordsFields();
                        break;
                    case 5:
                        productReviewMain.SkipTop5Records();
                        break;
                    case 6:
                        productReviewMain.RetrieveProductIdAndReview();
                        break;
                    case 7:
                        dataTableLinq.DisplayTable();
                        break;
                    case 8:
                        dataTableLinq.RetrieveWhoseIsLikeIsTrue();
                        break;
                    case 9:
                        dataTableLinq.AverageRatingUsingProductID();
                        break;
                    case 10:
                        productReviewMain.RetriveUsingMessage();
                        break;
                    case 11:
                        dataTableLinq.RetrieveUsingUserID();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}