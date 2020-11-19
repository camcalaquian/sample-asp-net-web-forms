using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common.Logging
{
    public class FolderPath
    {
        public static string ErrorLogFolder = $"{HttpRuntime.AppDomainAppPath}Logs/ApplicationError";
        public static string DebugLogFolder = $"{HttpRuntime.AppDomainAppPath}Logs/Debug";
        public static string CacheErrorFolder = $"{HttpRuntime.AppDomainAppPath}Logs/CacheError";
        public static string SessionStats = $"{HttpRuntime.AppDomainAppPath}Logs/SessionStats";

        public static List<string> All
        {
            get
            {
                return typeof(FolderPath)
                    .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                    .Where(f => f.FieldType == typeof(string))
                    .Select(x => (string)x.GetValue(null))
                    .ToList();
            }
        }
    }
}
