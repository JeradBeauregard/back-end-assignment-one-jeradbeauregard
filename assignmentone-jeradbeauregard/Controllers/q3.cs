using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3 : ControllerBase
    {
        /// <summary>
        /// Takes number input from the url end route and cubes it.
        ///
        /// </summary>
        /// <param name="userNum">the number to cube</param>
        /// <example>
        /// http://localhost:5066/api/q3/cube/4 -> 64
        /// http://localhost:5066/api/q3/cube/-4 -> -64
        /// http://localhost:5066/api/q3/cube/10 -> 1000
        /// </example>
        /// <returns>returns a cubed number based on the input number</returns>
        /// 
        [HttpGet(template:"cube/{userNum}")]

        public double cubed(double userNum)
        {
            return Math.Pow(userNum, 3);
        }

    }
}
