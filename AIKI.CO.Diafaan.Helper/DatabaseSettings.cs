using System;

namespace AIKI.CO.Diafaan.Helper
{
    public class DatabaseSettings
    {
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static string DataBaseUserName { get; set; }
        public static string DataBasePassword { get; set; }
        public static string SQLHelperConnectionString => $"data source={ServerName};user id={DataBaseUserName};password={DataBasePassword};initial catalog=IPM;Persist Security Info=true;";
    }
}
