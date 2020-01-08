using System;
using System.Collections.Generic;
using System.Text;

namespace AIKI.CO.Diafaan.Helper
{
    public class SMSServerSettings
    {
        public static string ServerName { get; set; }
        public static string Port { get; set; }
        public static string RestURL => $"https://{ServerName}:{Port}/http/";
    }
}
