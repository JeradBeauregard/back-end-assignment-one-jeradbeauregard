using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1 : ControllerBase
    {

        /// <summary>
        /// GET "http://localhost:5066/api/q1/welcome"
        /// calls welcomeMessage method which returns a string value of "Welcome"
        /// </summary>
        /// <returns>"Welcome to 5125"</returns>
        [HttpGet(template:"welcome")]

        public string welcomeMessage()
        {
            return "Welcome to 5125";
        }
    }
}
