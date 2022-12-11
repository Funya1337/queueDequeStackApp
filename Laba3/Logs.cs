using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Logs
    {
        List<string> logs = new List<string>();
        
        public void appendLog(string from, string method, int value)
        {
            string valString = value.ToString();
            DateTime dt = DateTime.Now;
            string sDate = dt.ToShortDateString();
            if (value == -1)
                logs.Add(sDate + " " + from + ": " + method + " method");
            else
                logs.Add(sDate + " " + from + ": " + method + " method, value: " + valString);
        }

        public string printLog(int index)
        {
            return logs[index];
        }
    }
}
