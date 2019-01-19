using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IntivePatronageCsTask2Ask.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzAskController : Controller
    {
        /// <summary>
        /// Access the FizzBuzz Get controller from the main project 
        /// </summary>
        /// <param name="fizzNumber">Number passed by ULR to be sent for for divisibility check</param>
        /// <returns>Returns the answer from FizzBuzz Get controller</returns>
        [HttpGet("{fizzNumber}")]
        public async Task<ActionResult> Get(int fizzNumber)
        {
            string reply = String.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/FizzBuzz/"+fizzNumber);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

                HttpResponseMessage response = await client.GetAsync("api/FizzBuzz/");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<String>();
                    if (result != null)
                    {
                        reply = result;
                    }
                }
            }
            return View(reply);
        }
    }
}
