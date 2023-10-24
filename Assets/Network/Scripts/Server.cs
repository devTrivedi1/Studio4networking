using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class Server : MonoBehaviour
{
    Socket socket;
    Socket client;
    void Start()
    {
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Blocking = false;
        socket.Bind(new IPEndPoint(IPAddress.Any, 3000));
        socket.Listen(10);
        Socket client = null;
    }
    void Update()
    {
        try
        {
            client = socket.Accept();
        }
        catch (SocketException ex)
        {
            if (ex.SocketErrorCode != SocketError.WouldBlock)
            {
                Console.WriteLine(ex);
            }
        }
        if (client != null)
        {

        }
    }
}
