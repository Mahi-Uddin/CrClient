﻿using System.Net.Sockets;
using Newtonsoft.Json;
using System.IO;

namespace CrClient
{
    public class ClientConfig
    {
        public static Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static byte[] SessionKey { get; set; }
        public static byte[] SharedKey { get; set; }
        public static byte[] ServerKey { get; set; }
        public static byte[] Nonce { get; set; }
        public static byte[] ServerNonce { get; set; }
        public static byte[] SNonce { get; set; }
        public static byte[] RNonce { get; set; }
    }
}
