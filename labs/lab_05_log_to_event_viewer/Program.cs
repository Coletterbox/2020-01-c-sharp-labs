using System;
using System.Diagnostics;

namespace lab_05_log_to_event_viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog.WriteEntry("Application", "Your system is about to expire.", EventLogEntryType.Error, 5000, 1234);
        }
    }
}
