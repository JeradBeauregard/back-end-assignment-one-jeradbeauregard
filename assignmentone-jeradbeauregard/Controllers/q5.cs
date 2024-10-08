﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentone_jeradbeauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5 : ControllerBase
    {

        /// <summary>
        /// Takes a user input from the end route
        /// Returns a secret message with the inputed number
        /// </summary>
        /// <param name="secret">this is the secret number input in the end route</param>
        /// <example>
        /// http://localhost:5066/api/q5/-200 -> Shh.. The secret is -200
        /// http://localhost:5066/api/q5/5 -> Shh.. The secret is 5
        /// </example>
        /// <returns>Returns a secret message and the same number that is inputed</returns>
        [HttpPost(template:"{secret}")]

        public string secretNum(int secret)
        {
            string response = "Shh.. The secret is " + secret;
            return response;
        }


    }
}
