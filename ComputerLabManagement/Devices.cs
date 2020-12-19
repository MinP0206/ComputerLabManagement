using System;
using System.Collections.Generic;
using System.Text;

namespace Detaicuoiki
{
    public abstract class Devices
    {
        public Devices()
        {
        }
        public string Room_id { set; get; }
        public string Device_id { set; get; }
        public DateTime Enumerate_date { set; get; }
        public DateTime LastCheck_date { set; get; }
        public Devices(string Room_id, string Device_id, DateTime Enumerate_date, DateTime LastCheck_date)
        {
            this.Room_id = Room_id;
            this.Device_id = Device_id;
            this.Enumerate_date = Enumerate_date;
            this.LastCheck_date = LastCheck_date;
        }
        public Devices(Devices a)
        {
            this.Room_id = a.Room_id;
            this.Device_id = a.Device_id;
            this.Enumerate_date = a.Enumerate_date;
            this.LastCheck_date = a.LastCheck_date;
        }
        public virtual string Print_DeviceInfo()
        {
            return $"Ma phong: {Room_id}\nMa thiet bi: {Device_id}\n" +
                $"Ngay dang kiem: {Enumerate_date}\nNgay kiem tra cuoi cung: {LastCheck_date}\n";
        }
        //public abstract void Using_Schedule();

    }

}
