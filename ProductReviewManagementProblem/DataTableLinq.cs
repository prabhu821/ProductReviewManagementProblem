using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblem
{
    public class DataTableLinq
    {
        DataTable dt = new DataTable();
        public void AddDataTable()
        {
            
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("Review", typeof(string));
            dt.Columns.Add("isLike", typeof(bool));

            DataRow row = dt.NewRow();
            dt.Rows.Add("1", "1", "5", "Excelent", true);
            dt.Rows.Add("2", "9", "2", "Bad", true);
            dt.Rows.Add("3", "8", "3", "Average", false);
            dt.Rows.Add("4", "2", "5", "Excelent", true);
            dt.Rows.Add("5", "5", "3", "Average", true);
            dt.Rows.Add("6", "2", "3", "Average", false);
            dt.Rows.Add("7", "4", "1", "Worst", true);
            dt.Rows.Add("8", "2", "5", "Excelent", false);
            dt.Rows.Add("9", "6", "5", "Excelent", false);
            dt.Rows.Add("1", "10", "4", "Good", true);
            dt.Rows.Add("1", "1", "2", "Bad", false);
            dt.Rows.Add("2", "10", "1", "Worst", true);
            dt.Rows.Add("3", "3", "3", "Average", true);
            dt.Rows.Add("4", "4", "4", "Good", false);
            dt.Rows.Add("5", "5", "5", "Excelent", true);
            dt.Rows.Add("6", "10", "3", "Average", false);
            dt.Rows.Add("7", "7", "2", "Bad", true);
            dt.Rows.Add("8", "8", "1", "Worst", false);
            dt.Rows.Add("9", "9", "3", "Average", false);
            dt.Rows.Add("2", "10", "4", "Good", true);
            dt.Rows.Add("1", "10", "1", "Worst", true);
            dt.Rows.Add("2", "2", "2", "Bad", false);
            dt.Rows.Add("3", "10", "3", "Average", true);
            dt.Rows.Add("4", "4", "4", "Good", false);
            dt.Rows.Add("5", "5", "5", "Excelent", true);
        }

        public void DisplayTable()
        {
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ProductID: {0}, UserID: {1}, Rating: {2}, Review: {3}, isLike: {4}",
                    row["ProductID"], row["UserID"], row["Rating"], row["Review"], row["isLike"]);
            }
        }

        //uc9
        public void RetrieveWhoseIsLikeIsTrue()
        {
            var results = from DataRow row in dt.Rows
                          where (bool)row["isLike"] == true
                          select row;
            foreach (DataRow row in results)
            {
                Console.WriteLine("ProductID: {0}, UserID: {1}, Rating: {2}, Review: {3}, isLike: {4}",
                    row["ProductID"], row["UserID"], row["Rating"], row["Review"], row["isLike"]);
            }
        }

        //uc10
        public void AverageRatingUsingProductID()
        {
            var results = from DataRow row in dt.Rows
                          group row by row["ProductID"] into g
                          select new
                          {
                              ProductID = g.Key,
                              AvgRating = g.Average(row => (int)row["Rating"])
                          };
            foreach (var result in results)
            {
                Console.WriteLine("ProductID: {0}, AvgRating: {1}",
                    result.ProductID, result.AvgRating);
            }
        }

        //uc12
        public void RetrieveUsingUserID()
        {
            var results = from DataRow row in dt.Rows
                          where (int)row["UserID"] == 10
                          orderby (int)row["Rating"]
                          select row;
            foreach (DataRow row in results)
            {
                Console.WriteLine("ProductID: {0}, UserID: {1}, Rating: {2}, Review: {3}, isLike: {4}",
                    row["ProductID"], row["UserID"], row["Rating"], row["Review"], row["isLike"]);
            }
        }
    }
}
