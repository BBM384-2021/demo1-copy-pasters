using LoginAuth.Data;
using LoginAuth.Models.ClubModels;
using Microsoft.AspNetCore.Mvc;

namespace LoginAuth.Controllers
{
    [Route("Panel/[action]")]
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminPanelController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult AddClub([FromBody] Club club)
        {
            if (ModelState.IsValid)
            {
                _db.Clubs.Add(club);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return Ok(); // TODO: there is an error.
        }

        [HttpPost]
        public IActionResult AddSubClub([FromBody] SubClub subClub)
        {
            if (ModelState.IsValid)
            {
                _db.SubClubs.Add(subClub);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return Ok(); // TODO: there is an error.
        }

        [HttpPost]
        public IActionResult AddQuestion([FromBody] Question question)
        {
            if (ModelState.IsValid)
            {
                _db.Questions.Add(question);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return Ok(); // TODO: there is an error.
        }
    }
}