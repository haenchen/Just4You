using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You
{
    public static class GlobalLogger
    {
        private static List<String> Log = new List<string>();

        private static int OutputIndex = 0;

        private static int QueryIndex = 0;

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
            for(;OutputIndex < Log.Count(); OutputIndex++)
            {
                TempList.Add(Log[OutputIndex]);
            }
            return TempList;
        }

        public static bool NewErrorsExist()
        {
            bool newErrors = QueryIndex < Log.Count;
            QueryIndex = Log.Count;
            return newErrors;
        }
    }
}
