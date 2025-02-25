using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstone.Models;

namespace firstone.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {


        ViewData["indexMessage"] = "cosmld";
        //view method creates  viewResult object  implements IAction result interface

        return View();
    }



/*to implement async and wait multithedaing future and   std::promise

public  async Task<IActionResult> ActionName(){

var data = await datatype<T>.getAsync();  promise theraddtata;
 
return  View(data);

}

  **/
    public IActionResult Privacy()
    {
        return base.View();  
        
        //returns viewresult  fro mm views that  maps  to nmae of action//privacy
    }

    public IActionResult About()
    {


        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
