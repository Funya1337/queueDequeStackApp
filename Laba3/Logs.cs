using System;
using System.Collections.Generic;
using System.IO;

namespace Laba3
{
    class Logs
    {
        List<string> logs = new List<string>();

        public void appendLog(string from, string method)
        {
            DateTime dt = DateTime.Now;
            string log = $"{dt} | {from} : {method} method";
            logs.Add(log);
        }

        public List<string> getLogsArray()
        {
            return logs;
        }

        public void writeLogsInFile()
        {
            var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Logs.txt"));
            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                logs.ForEach(delegate (string line)
                {
                    file.WriteLine(line);
                });
            }
        }
        public void clearLogs()
        {
            var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Logs.txt"));
            File.WriteAllText(path, String.Empty);
        }
    }
}
