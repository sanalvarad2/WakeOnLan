using System;
using System.Globalization;
using System.Net;

namespace Application.WOL
{
    public static class Wake
    {
        public static bool WakeFunction(string MAC_ADDRESS)
        {
            try
            {
                WOLClass client = new WOLClass();
                client.Connect(new
                   IPAddress(0xffffffff),  //255.255.255.255  i.e broadcast
                   0x2fff); // port=12287 let's use this one 
                client.SetClientToBrodcastMode();
                //set sending bites
                int counter = 0;
                //buffer to be send
                byte[] bytes = new byte[1024];   // more than enough :-)
                                                 //first 6 bytes should be 0xFF
                for (int y = 0; y < 6; y++)
                {
                    bytes[counter++] = 0xFF;
                }
                //now repeate MAC 16 times
                for (int y = 0; y < 16; y++)
                {
                    int i = 0;
                    for (int z = 0; z < 6; z++)
                    {
                        bytes[counter++] =
                            byte.Parse(MAC_ADDRESS.Substring(i, 2),
                            NumberStyles.HexNumber);
                        i += 2;
                    }
                }
                client.EnableBroadcast = true;
                //now send wake up packet
                int reterned_value = client.Send(bytes, 1024);


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
