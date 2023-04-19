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
        //uc1
        public void RetriveTopRecords()
        {
            var result = this.productReviews.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
    }
}
