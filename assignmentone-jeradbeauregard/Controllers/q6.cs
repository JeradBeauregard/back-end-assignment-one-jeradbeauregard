using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6 : ControllerBase
    {
        /// <summary>
        /// Takes an input from the end route as a value of the side of a hexagon
        /// uses the hexagonArea method to output the area of the hexagon
        /// </summary>
        /// <param name="side">the input side length of a hexagon</param>
        /// <example>
        /// http://localhost:5066/api/q6/1 -> 2.598076211353316
        /// http://localhost:5066/api/q6/1.5 -> 5.845671475544961
        /// http://localhost:5066/api/q6/20 -> 1039.2304845413264
        /// 
        /// </example>
        /// <returns>The area of a hexagon based on the input side length</returns>
        [HttpGet(template:"{side}")]

        public double hexagaonArea(double side)
        {
            double hexagon = ((3 * Math.Sqrt(3)) / 2)*(Math.Pow(side, 2));
            return hexagon;
        }
    }
}
