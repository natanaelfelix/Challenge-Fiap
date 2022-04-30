using System;
using System.Collections.Generic;
using System.Text;

namespace CHAFIAP.MODEL.Configuration {
    public class Connect {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }
        public string SSLMode { get; set; }
    }
}
