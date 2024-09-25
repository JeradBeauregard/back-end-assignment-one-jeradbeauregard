using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1 : ControllerBase
    {

        /// <summary>
        /// 
        /// calls welcomeMessage method which returns a string value of "Welcome"
        /// <example>
        /// GET "http://localhost:5066/api/q1/welcome" -> Welcome to 5152
        /// </example>
        /// </summary>
        /// <returns>"Welcome to 5125"</returns>
        [HttpGet(template:"welcome")]

        public string welcomeMessage()
        {
            return "Welcome to 5125";
        }
    }
}
