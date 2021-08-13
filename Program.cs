using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessViewer;

namespace tcpkill
{
    class Program
    {
        [Flags]
        public enum MyEnum:long
        {
            TEST = 1125900090893759
        }
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                if (int.TryParse(args[0], out int port))
                {
                    NetProcessAPI.CloseConnByLocalPort(port);
                }
            }
        }
    }
}
