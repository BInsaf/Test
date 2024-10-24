using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Bad
    {
        void M()
        {
            Logger.Log("Hello, World!");
        }

        static class Logger
        {
            [Obsolete("Use Log(LogLevel level, string s) instead")]
            public static void Log(string s)
            {
                // ...
            }

            public static void Log(LogLevel level, string s)
            {
                // ...
            }
        }

        enum LogLevel
        {
            Info,
            Warning,
            Error
        }
    }
}
