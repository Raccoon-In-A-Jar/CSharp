using System;
using System.Net.Sockets;
using System.Text;

public class TcpListenerClient
{
    private const int portNum = 1302;
    private const string hostName = "127.0.0.1";    //Console.ReadLine();    //"127.0.0.1" for local host;
    

    public static int Main(String[] args)
    {
        try
        {
            byte[] bytes;
            int bytesRead;

            //the "server" variable stores information about the server
            TcpClient server = new TcpClient(hostName, portNum);

            //the "ns" variable stores the NetworkStream of the server
            NetworkStream ns = server.GetStream();

            
            //------------------------------vvv CRITICAL TO RECEIVE AND DISPLAY A MESSAGE vvv------------------------------
            
            //the "bytes" is meant to store the message
            bytes = new byte[1024];
            //receives the message of the NetworkStream of the server -- reads the NetworkStream "ns" and stores it in "bytes"
            bytesRead = ns.Read(bytes, 0, bytes.Length);
            //displays the message stored in "bytes" after converting it into string
            Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));
            
            //------------------------------^^^ CRITICAL TO RECEIVE AND DISPLAY A MESSAGE ^^^------------------------------


            ns.Close();
            server.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        return 0;
    }
}