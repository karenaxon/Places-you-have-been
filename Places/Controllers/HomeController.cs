using Microsoft.AspNetCore.Mvc;

namespace PlacesYouHaveBeen.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}