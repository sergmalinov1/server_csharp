using System;
using System.Collections.Generic;
using System.Text;

namespace ClientTest
{
    class ClientSend
    {
        private static void SendTCPData(Packet _packet)
        {
            _packet.WriteLength();
            Client.instance.tcp.SendData(_packet);
        }


        private static void SendUDPData(Packet _packet) // 3 part
        {
            _packet.WriteLength();
            Client.instance.udp.SendData(_packet);
        }

        #region Packets
        public static void WelcomeReceived()
        {
            using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
            {

                string _msg = "Hello from client ";
                _packet.Write(Client.instance.myId);
                _packet.Write(_msg);
                //  _packet.Write(UIManager.instance.usernameField.text);

                SendTCPData(_packet);
            }
        }


        public static void UDPTestReceived()
        {
            using (Packet _packet = new Packet((int)ClientPackets.updTestReceived))
            {
                _packet.Write("Received a UDP packet.");

                SendUDPData(_packet);
            }
        }
        #endregion
    }
}
