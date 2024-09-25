using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4 : ControllerBase
    {
        /// <summary>
        /// Post request http://localhost:5066/api/q4/knockknock -> Who's There?
        /// </summary>
        /// <returns>
        /// Who's There?
        /// </returns>
        [HttpPost(template: "knockknock")]

        public string whosThere()
        {
            return "Who's There?";
        }
    }
}
