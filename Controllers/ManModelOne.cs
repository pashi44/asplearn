using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using firstone.Models;
namespace firstone.Controllers{


public class ManModelOneController  : Controller{

public IActionResult ManualView(){

    //  the models are created  here and returned view viewData or result


var  itemone = new ManModelOne();


itemone.Id  =  79;
            itemone.Name = "pashi";


            // {Id =   256, Name = "pashi"};
            return View(itemone);

}



public  ViewResult todo(){

var   itemtwo = new ManModelOne(){Name = null};

return View(itemtwo);


}

}


}