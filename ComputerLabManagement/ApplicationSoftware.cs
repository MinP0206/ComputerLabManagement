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

        public ApplicationSoftware() { }
        public ApplicationSoftware(string type, string onOS, float version)
        {
            Type = type;
            OnOS = onOS;
            Version = version;
        }
        public ApplicationSoftware(ApplicationSoftware x)
        {
            x.Type = this.Type;
            x.OnOS = this.OnOS;
            x.Version = this.Version;
        }
        public float Version
        {
            set { this.Version_ = value; }
            get { return Version_; }
        }
    }
}
