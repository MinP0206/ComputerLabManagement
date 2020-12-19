using System;
using System.Collections.Generic;
using System.Text;

namespace Detaicuoiki
{
    public enum CPU_S { XeonE3, XeonE5, XeonGOLD }
    public enum RAM_S { DDR3ECC, DDR4ECC }
    public class Server : Devices
    {
        CPU_S CPU_SType;
        RAM_S RAM_SType;

        public void SetUp() { }
        public void programming() { }

        public void operation() { }

    }
}
