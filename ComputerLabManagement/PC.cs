using System;
using System.Collections.Generic;
using System.Text;

namespace Detaicuoiki
{
    public enum CPU { i3, i5, i7}
    public enum RAM { DDR3, DDR4}
    public class PC : Devices
    {
        CPU CPUType;
        RAM RAMType;
        public string POWER;

        public PC()
        {
        }
        public PC(PC a) : base(a)
        {
            this.CPUType = a.CPUType;
            this.RAMType = a.RAMType;
            this.POWER = a.POWER;
        }
        public PC(string Room_id, string Device_id, DateTime Enumerate_date, DateTime LastCheck_date,
            CPU CPUType, RAM RAMType, string POWER)
            :base(Room_id, Device_id, Enumerate_date, LastCheck_date)
        {
            this.CPUType = CPUType;
            this.RAMType = RAMType;
            this.POWER = POWER;
        }
        public override string Print_DeviceInfo()
        {
            return base.Print_DeviceInfo() +
                $"CPU: {CPUType}\nRAM: {RAMType}\nPOWER: {POWER}";
        }
    }
}
