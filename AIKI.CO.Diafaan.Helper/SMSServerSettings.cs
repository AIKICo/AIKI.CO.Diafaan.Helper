using System;
using System.Collections.Generic;
using System.Text;

namespace AIKI.CO.Diafaan.Helper
{
    public class SMSServerSettings
    {
        public static string ServerName { get; set; }
        public static short Port { get; set; }
        public static string UserName { get; set; } = "admin";
        public static string Password { get; set; }
        public static string RestURL => $"https://{ServerName}:{Port.ToString()}/http/";
    }
}
