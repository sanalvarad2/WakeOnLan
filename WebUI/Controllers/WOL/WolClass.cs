using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebUI.Controllers.WOL
{
    public partial class WolClass
    {
        public string macAddress { get; set; }
        public string hostName { get; set; }

        public bool HasMac()
        {
            bool retVal;
            if (!string.IsNullOrWhiteSpace(macAddress))
            {
                retVal = true;
            }
            else
            {
                retVal = false;
            }
            return retVal;
        }
        
    }
}
