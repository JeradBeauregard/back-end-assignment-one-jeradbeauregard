using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8 : ControllerBase
    {
        /// <summary>
        /// Takes two user inputs from the end route to determine the amount of small and large SquashFellows ordered.
        /// </summary>
        /// <param name="small">the ammount of small squashfellows ordered</param>
        /// <param name="large">the ammount of large squashfellows ordered</param>
        /// <example>
        /// http://localhost:5066/api/q8/100,100 -> 100 Small @ $25.50 = $$2,550.00; 100 Large @ $40.50 = $$4,050.00; Subtotal = $6,600.00; Tax = $$858.00 HST; Total = $$7,458.00
        /// http://localhost:5066/api/q8/1,1 -> 1 Small @ $25.50 = $$25.50; 1 Large @ $40.50 = $$40.50; Subtotal = $66.00; Tax = $$8.58 HST; Total = $$74.58
        /// http://localhost:5066/api/q8/1,2 -> 1 Small @ $25.50 = $$25.50; 2 Large @ $40.50 = $$81.00; Subtotal = $106.50; Tax = $$13.84 HST; Total = $$120.34
        /// </example>
        /// <returns>
        /// The amount of product ordered, the cost of each product, the subtotal of the whole order, the taxes and finally the total cost of the order.
        /// </returns>
        [HttpPost(template: "{small},{large}")]

        public string test(double small, double large)
        {
           
            double smallCost = small*25.50;
            double largeCost = large*40.50;
            double subtotal = smallCost + largeCost;
            double tax = subtotal * 0.13;
            double total = subtotal + tax;
           // return Math.Round(rounded, 2);
            return $"{small} Small @ $25.50 = ${Math.Round(smallCost, 2).ToString("C")}; {large} Large @ $40.50 = ${Math.Round(largeCost, 2).ToString("C")}; Subtotal = {Math.Round(subtotal, 2).ToString("C")}; Tax = ${Math.Round(tax, 2).ToString("C")} HST; Total = ${Math.Round(total, 2).ToString("C")}";


        }
    }
}
