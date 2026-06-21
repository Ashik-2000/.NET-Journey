using Microsoft.AspNetCore.Mvc;
using WebApplicationTutorial1.Models;

namespace WebApplicationTutorial1.controllers
{
    public class HomeController: Controller
    {
        [Route("getResponse")]
        public IActionResult getResponse(Profile request)
        {
            if (!ModelState.IsValid)
            {
                var errorList = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                var error = string.Join(", ",errorList);
                return BadRequest(error);
            }
            return Ok(request.ToString());
        }
    }
}
