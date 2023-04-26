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
            dt.Rows.Add("2", "2", "2", "Bad", true);
            dt.Rows.Add("3", "3", "3", "Average", false);
            dt.Rows.Add("4", "4", "5", "Excelent", true);
            dt.Rows.Add("5", "5", "3", "Average", true);
            dt.Rows.Add("6", "5", "3", "Average", false);
            dt.Rows.Add("7", "4", "1", "Worst", true);
            dt.Rows.Add("8", "8", "5", "Excelent", false);
            dt.Rows.Add("9", "9", "5", "Excelent", false);
            dt.Rows.Add("10", "10", "4", "Good", true);
            dt.Rows.Add("11", "11", "2", "Bad", false);
            dt.Rows.Add("12", "12", "1", "Worst", true);
            dt.Rows.Add("13", "13", "3", "Average", true);
            dt.Rows.Add("14", "14", "4", "Good", false);
            dt.Rows.Add("15", "15", "5", "Excelent", true);
            dt.Rows.Add("16", "16", "3", "Average", false);
            dt.Rows.Add("17", "17", "2", "Bad", true);
            dt.Rows.Add("18", "18", "1", "Worst", false);
            dt.Rows.Add("19", "19", "3", "Average", false);
            dt.Rows.Add("20", "20", "4", "Good", true);
            dt.Rows.Add("21", "21", "1", "Worst", true);
            dt.Rows.Add("22", "22", "2", "Bad", false);
            dt.Rows.Add("23", "23", "3", "Average", true);
            dt.Rows.Add("24", "24", "4", "Good", false);
            dt.Rows.Add("25", "25", "5", "Excelent", true);
        }

        public void DisplayTable()
        {
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ProductID: {0}, UserID: {1}, Rating: {2}, Review: {3}, isLike: {4}",
                    row["ProductID"], row["UserID"], row["Rating"], row["Review"], row["isLike"]);
            }
        }
    }
}
