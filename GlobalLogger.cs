using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You;
{
    public static class GlobalLogger
    {
        private static List<String> Log;

        private static int LastIndex;

        public static void addError(String Error)
        {
            Log.Add(Error);
        }

        public static List<String> GetAllErrors()
        {
            return Log;
        }

        public static List<String> GetRecentErrors()
        {
            var TempList = new List<String>();
            for(;LastIndex < Log.Count(); LastIndex++)
            {
                TempList.Add(Log[LastIndex]);
            }
            return TempList;
        }
    }
}
