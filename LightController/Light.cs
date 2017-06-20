using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace LightController
{
    enum PatternType
    {
        Jumping = 0,
        Gradual = 1,
        Strobe = 2
    }
    enum PresetMode
    {
        StaticRed = 128,
        StaticBlue = 129,
        StaticGreen = 130,
        StaticCyan = 131,
        StaticYellow = 132,
        StaticPurple = 133,
        StaticWhite = 134,
        TricolorJump = 135,
        SevenColorJump = 136,
        TricolorGradient = 137,
        SevenColorGradient = 138,
        RedGradient = 139,
        GreenGradient = 140,
        BlueGradient = 141,
        YellowGradient = 142,
        CyanGradient = 143,
        PurpleGradient = 144,
        WhiteGradient = 145,
        RedGreenGradient = 146,
        RedBlueGradient = 147,
        GreenBlueGradient = 148,
        SevenColorFlash = 149,
        RedFlash = 150,
        GreenFlash = 151,
        BlueFlash = 152,
        YellowFlash = 153,
        CyanFlash = 154,
        PurpleFlash = 155,
        WhiteFlash = 156
    }
    class Light
    {

        private Socket sock;

        public Light(string ip, int port = 5000)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ipAdd = IPAddress.Parse(ip);
            IPEndPoint remoteEP = new IPEndPoint(ipAdd, port);
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

        public void on()
        {
            send(new byte[] { 0x7e, 0x04, 0x04, 0x01, 0xff, 0xff, 0xff, 0x00, 0xef });
        }

        public void off()
        {
            send(new byte[] { 0x7e, 0x04, 0x04, 0x00, 0xff, 0xff, 0xff, 0x00, 0xef });
        }

        public void temp(int v = 10)
        {
            /*0 - 10*/
            byte value = Convert.ToByte(128 + v);
            send(new byte[] { 0x7e, 0x05, 0x03, value, 0x02, 0xff, 0xff, 0x00, 0xef });
        }

        public void dim(int v = 10)
        {
            /*0 - 10*/
            byte value = Convert.ToByte(128 + v);
            send(new byte[] { 0x7e, 0x05, 0x03, value, 0x01, 0xff, 0xff, 0x00, 0xef });
        }

        public void brightness(int v = 100)
        {
            /*0 - 100*/
            byte value = Convert.ToByte(v);
            send(new byte[] { 0x7e, 0x04, 0x01, value, 0xff, 0xff, 0xff, 0x00, 0xef });
        }

        public void rgb(int r, int g, int b, bool fade = true)
        {
            byte fadeVal;
            if (fade) fadeVal = 0x03;
            else fadeVal = 0x04;
            send(new byte[] { 0x7e, 0x07, 0x05, fadeVal, Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b), 0x00, 0xef });
        }

        public void preset(PresetMode mode)
        {
            byte value = Convert.ToByte(mode);
            send(new byte[] { 0x7e, 0x05, 0x03, value, 0x03, 0xff, 0xff, 0x00, 0xef });
        }

        public void pattern(PatternType type, int[] pattern)
        {
            /* pattern = [r, g, b, r, g, b...]  */
            byte typeVal = Convert.ToByte(type);
            byte coundVal = Convert.ToByte(pattern.Length);
            List<byte> byteList = new List<byte>(new byte[] { 0xaf, 10, coundVal, 0x03 });
            foreach (int v in pattern) {
                byteList.Add(Convert.ToByte(v));
            }
            send(byteList.ToArray());
        }

        public void speed(int v = 200)
        {
            /*0 - 200*/
            byte value = Convert.ToByte(v);
            send(new byte[] { 0x7e, 0x04, 0x02, value, 0xff, 0xff, 0xff, 0x00, 0xef });
        }

    }
}
