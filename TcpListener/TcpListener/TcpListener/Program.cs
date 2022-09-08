using System;
using System.Net.Sockets;
using System.Text;

public class TcpListenerServer
{

    private const int portNum = 1302;

    public static int Main(String[] args)
    {
        bool done = false;

        //Instantiate a listener and links it to a port
        TcpListener listener = new TcpListener(portNum);
        
        //starts the listener (obviously), but doesn't accept any input
        listener.Start();

        while (!done)
        {
            Console.Write("Waiting for connection...");
            //the "client" variable is "white-listed" for the listener to accept an incoming connection from a TcpClient
            TcpClient client = listener.AcceptTcpClient();

            Console.WriteLine("Connection accepted.");
            //the "ns" variable stores the NetworkStream of the client
            NetworkStream ns = client.GetStream();

            //converts data into binary data
            byte[] bytes = Encoding.ASCII.GetBytes("I love raccoons!");

            try
            {
                //writes data (from the "bytes" variable) on the NetworkStream of the client
                ns.Write(bytes, 0, bytes.Length);

                //closes the NetworkStream
                ns.Close();
                //disconnects from the client
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Server stops listening
        listener.Stop();

        return 0;
    }

}