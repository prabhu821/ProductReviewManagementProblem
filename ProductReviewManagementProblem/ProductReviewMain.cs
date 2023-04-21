using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblem
{
    public class ProductReviewMain
    {
        List<ProductReview> productReviews = new List<ProductReview>();
        public void AddProductList(List<ProductReview> list)
        {
            this.productReviews = list;
        }
        public void Display(List<ProductReview> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("ProductId: " + item.ProductId + " UserId: " + item.userId + " Rating: " + item.Rating + " Review: " + item.Review + " IsLike: " + item.IsLike);
            }
        }

        //uc2
        public void RetriveTopRecords()
        {
            var result = this.productReviews.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }

        //uc3
        public void RetriveAllRecords()
        {
            var result = this.productReviews.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9));
            Display(result.ToList());
        }

        //uc4
        public void RetriveAllRecordsGroupBy()
        {
            var result = this.productReviews.GroupBy(x => x.ProductId);
            foreach (var item in result)
            {
                Console.WriteLine(item.Count());
                Display(item.ToList());
            }
        }

        //uc5
        public void RetriveAllRecordsFields()
        {
            var result = this.productReviews.Select(x => new { x.ProductId, x.Rating });
            foreach (var item in result)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " ==>  Rating : " + item.Rating);
            }
        }

        //uc6
        public void SkipTop5Records()
        {
            var result = this.productReviews.OrderByDescending(x => x.Rating).Skip(5);
            Display(result.ToList());
        }

        //uc7  
        public void RetrieveProductIdAndReview()
        {
            var result = this.productReviews.Select(x => new { x.ProductId, x.Review });
            foreach (var item in result)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " ==> Review : " + item.Review);
            }
        }
    }
}
