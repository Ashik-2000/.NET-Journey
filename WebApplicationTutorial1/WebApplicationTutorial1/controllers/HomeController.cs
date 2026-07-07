using Microsoft.AspNetCore.Mvc;
using WebApplicationTutorial1.Models;

namespace WebApplicationTutorial1.controllers
{
    public class HomeController: Controller
    {
        [Route("getResponse")]
        public IActionResult GetResponse(Profile request)
        {
            if (!ModelState.IsValid)
            {
                var errorList = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                var error = string.Join(", ",errorList);
                return BadRequest(error);
            }
            return Ok(request.ToString());
        }

        [Route("View")]
        [Route("/")]
        public IActionResult ViewPractice()
        {
            return View();
        }

        [Route("home")]
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
