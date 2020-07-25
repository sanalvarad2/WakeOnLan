using System.Net.Sockets;

namespace Application.WOL
{
    public class WOLClass : UdpClient
    {
        public WOLClass() : base()
        { }
        //this is needed to send broadcast packet
        public void SetClientToBrodcastMode()
        {
            if (this.Active)
                this.Client.SetSocketOption(SocketOptionLevel.Socket,
                                          SocketOptionName.Broadcast, 0);
        }
    }
}
