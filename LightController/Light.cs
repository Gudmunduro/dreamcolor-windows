using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace LightController
{
    class Light
    {
        Socket sock;

        public Light(string ip, int port = 5000)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(ip);
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, port);
            sock.Connect(remoteEP);
        }

        private void send(byte[] data)
        {
            sock.Send(data);
        }

        public bool isConnected
        {
            get
            {
                bool bool1 = sock.Poll(1000, SelectMode.SelectRead);
                bool bool2 = (sock.Available == 0);
                if (bool1 && bool2)
                    return false;
                else
                    return true;
            }
        }

        public void dim(int a = 10)
        {
            byte value = Convert.ToByte(128 + a);
            send(new byte[] { 0x7e, 0x05, 0x03, value, 0x01, 0xff, 0xff, 0x00, 0xef });
        }

        public void rgb(int r, int g, int b, bool fade = true)
        {
            byte fadeVal;
            if (fade) fadeVal = 0x03;
            else fadeVal = 0x04;
            send(new byte[] { 0x7e, 0x07, 0x05, fadeVal, Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b), 0x00, 0xef });
        }

        public void on()
        {
            send(new byte[] { 0x7e, 0x04, 0x04, 0x01, 0xff, 0xff, 0xff, 0x00, 0xef });
        }

        public void off()
        {
            send(new byte[] { 0x7e, 0x04, 0x04, 0x00, 0xff, 0xff, 0xff, 0x00, 0xef });
        }
    }
}
