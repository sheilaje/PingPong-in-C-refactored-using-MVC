using Microsoft.AspNetCore.Mvc;
using Pingpong.Models;

namespace Pingpong.Controllers
{
    public class HomeController : Controller
    {

      [Route("/")]
      public ActionResult Index() { return View(); }

      [Route("/pingpong")]
      public ActionResult Results(int number) {
        PingPongGenerator myPingpongCheck = new PingPongGenerator();
        myPingpongCheck.SetInput(number);
        // myPingpongCheck.PingpongCheck();
        return View(myPingpongCheck);
      }


    }
}
