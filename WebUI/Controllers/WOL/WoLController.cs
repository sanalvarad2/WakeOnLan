using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.WOL
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WoLController : ControllerBase
    {
        [HttpPost]
        public IActionResult Wake(WolClass Obj){
            bool retVal = false;
            if (Obj.HasMac())
            {
                string macClean = Obj.macAddress.Replace("-", "");
                retVal = Application.WOL.Wake.WakeFunction(macClean);
            }
            return Ok(retVal);
        }
    }
}
