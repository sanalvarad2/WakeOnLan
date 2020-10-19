using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using app = Application.ComputerHost;

namespace WebUI.Controllers.Dispositivos
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DispositivosController : ControllerBase
    {
        
        [HttpPost]
        public async Task<IActionResult> GetMacAddressAsync(string hostname)
        {
            Commons.ReturnValue<string> retVal = new Commons.ReturnValue<string>();

            try
            {
                IPAddress ip = await app.GetAddress.GetHost(hostname);
                bool pingeable = Application.PingHost.PingHost.Ping_Host(ip);
                string mac = app.GetAddress.getMacByIp(ip.ToString());
                retVal.isSuccess = true;
                retVal.Data = mac;
            }
            catch (Exception ex)
            {
                retVal.isSuccess = false;
                retVal.ErrorMessage = ex.Message;
            }
            return Ok(retVal);


        }
    }
}
