using   System.Diagnostics;
using  Microsoft.AspNetCore.Mvc;
using  firstone.Models;

using firstone.DBdata;
//using th db model

namespace  firstone.Controllers
{
    


    public  class ApplicationdbController :  Controller{

private ApplicationDbContent _obj;

//where in  older legay  code wheree we used to derive \
//the dbcontext and open sql connections and close those
//but wiht core we add this service to the
//pipeline so we dont have to  define those connection. we cam
//ask the builder service 
// to  give  an db conetxt obejct 
public  ApplicationdbController(ApplicationDbContent dBContentObj){

_obj =  dBContentObj;

}


public IActionResult  DbView()
{

List<Employees>  dblistofemplyees  =



// we are reminedung the service builder that we are refering
//Dbconetcxt of type Emplyees define object employee in applicationdbcontext from
//  DBdata
_obj.employees.ToList();



return View(dblistofemplyees);

}

}
}







