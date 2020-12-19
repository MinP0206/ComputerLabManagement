using System;
using System.Collections.Generic;
using System.Text;

namespace Detaicuoiki
{
    class ApplicationSoftware
    {
        public string Type { set; get; }
        public string OnOS { set; get; }

    
        public float Version_;
        public float Version
        {
            set { this.Version_ = value; }
            get { return Version_; }
        }
    }
}
