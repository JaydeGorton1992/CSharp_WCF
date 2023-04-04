using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace WCFServer
{
    [ServiceContract]
    interface ITestContract
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);

        [OperationContract]
        string[] Sort(string[] items);
    }
}
