using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace WCFServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class IPCTestServer : ITestContract
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public string[] Sort(string[] items)
        {
            Array.Sort(items);
            return items;
        }
    }
}
