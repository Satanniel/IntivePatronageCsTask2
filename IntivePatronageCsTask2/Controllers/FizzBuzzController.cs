using Microsoft.AspNetCore.Mvc;
using System;

namespace IntivePatronageCsTask2.Controllers
{
    
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {
        /// <summary>
        /// FizzBuzz method. 
        /// </summary>
        /// <param name="fizzNumber">Number passed by ULR to be checked for divisibility</param>
        /// <returns>Returns "Fizz" if the number passed divisible by two, "Buzz" if by three, "FizzBuzz" if by both, empty if none, warning message if the number is from outside 0-1000 range.</returns>
        [HttpGet("{fizzNumber}")]
        public string Get(int fizzNumber)
        {
            string reply = String.Empty;
            if (fizzNumber < 0 || fizzNumber > 1000)
            {
                reply = "The entered number is not in the 0 - 1000 range.";
            }
            else
            {
                if (fizzNumber % 2 == 0)
                {
                    reply += "Fizz";
                }
                if (fizzNumber % 3 == 0)
                {
                    reply += "Buzz";
                }
            }
            return reply;
        }
    }
}
