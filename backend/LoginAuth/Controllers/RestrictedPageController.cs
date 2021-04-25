using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginAuth.Controllers
{
    public class RestrictedPageController : Controller
    {
        [Authorize]
        public IActionResult ProfilePage()
        {
            return Ok();
        }
    }
}