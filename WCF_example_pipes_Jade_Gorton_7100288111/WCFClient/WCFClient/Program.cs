using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

//https://gorillacoding.wordpress.com/2013/02/03/using-wcf-for-inter-process-communication/
namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/Jade/IPCTest";

            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            ITestContract channel = ChannelFactory<ITestContract>.CreateChannel(binding, ep);

            Console.WriteLine("Client Connected");

            Console.WriteLine(" 2 + 2 = {0}", channel.Add(2, 2));
            Console.WriteLine(" 256 - 89 = {0}", channel.Subtract(256, 89));
            Console.WriteLine("DACB = {0},{1},{2},{3}",channel.Sort(new string[]{"D","A","C","B"}));
            Console.ReadLine();
        }
    }
}
