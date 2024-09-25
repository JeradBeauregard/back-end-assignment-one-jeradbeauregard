using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2 : ControllerBase
    {
        /// <summary>
        /// [HttpGet(template: "greetings/{userName}")]
        ///     takes input from the url and stores is in userName Variable
        ///public string helloName(string userName)
        ///      takes username variable as a parameter for method helloName  
        /// </summary>
        /// <param name="userName">Takes and inputed username</param>
        ///<example>
        ///"http://localhost:5066/api/q2/greetings/Jerad" -> Hello Jerad
        /// </example>
        /// <returns>the message Hello and then the inputed username</returns>
        [HttpGet(template: "greetings/{userName}")]

        public string helloName(string userName)
        {
            return "Hello " + userName +"!";
        }
    }
}
