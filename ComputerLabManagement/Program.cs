using System;

namespace Detaicuoiki
{
    class Program
    {
        static void Main(string[] args)
        {
            PC S = new PC("A5-302", "PC01", new DateTime(2015,3,2), new DateTime(2018, 3, 2), 
                CPU.i5, RAM.DDR4, "700W");
            PC B = new PC(S);
            Console.WriteLine(B.Print_DeviceInfo());
        }
    }
}
