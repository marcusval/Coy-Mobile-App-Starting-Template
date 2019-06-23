using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 

namespace test2.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
