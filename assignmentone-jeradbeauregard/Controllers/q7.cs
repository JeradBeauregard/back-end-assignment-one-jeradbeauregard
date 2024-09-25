using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7 : ControllerBase
    {

        /// <summary>
        /// Takes a user input from the end route, uses timeMachine method to add or 
        /// subracts days from the current time...
        /// days added or subtracted are based on the user input.
        /// </summary>
        /// <param name="days">the amount of days to be added or subtracted from the current date</param>
        /// <returns>
        /// the current date plus or minus the amount of days input
        /// </returns>
        [HttpGet(template:"{days}")]

        public string timeMachine(double days)
        {
           DateTime thisDay = DateTime.Today;  

            DateTime newTime = thisDay.AddDays(days);

            return newTime.ToString();
        }
    }
}
