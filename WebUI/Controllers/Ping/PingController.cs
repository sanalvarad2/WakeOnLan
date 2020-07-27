using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using app = Application;
using cmmn = Commons;

namespace WebUI.Controllers.Ping
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("{hostname}")]
        public async Task<IActionResult> GetAsync(string hostname)
        {
            cmmn.ReturnValue<bool> retVal = new cmmn.ReturnValue<bool>();
            try
            {
                IPAddress iPAddress = await app.ComputerHost.GetAddress.GetHost(hostname);

                if (iPAddress != null)
                {
                    retVal.Data = app.PingHost.PingHost.Ping_Host(iPAddress);
                    retVal.isSuccess = true;
                } 
            }
            catch(Exception ex)
            {
                retVal.isSuccess = false;
                retVal.ErrorMessage = ex.Message;
            }

            return Ok(retVal);
        }
    }
}
