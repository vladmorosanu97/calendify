using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Utils
{
    public class AppSettings
    {
        public string[] AllowedHosts { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
