using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading.Tasks;

namespace Netfluid.Logging
{
    public class FileLogger : Logger
    {
        readonly Task task;
        readonly StreamWriter writer;
        readonly BlockingCollection<string> queue;

        public FileLogger(string path)
        {
            queue = new BlockingCollection<string>();
            writer = new StreamWriter(new FileStream(path, FileMode.Append));
            task = Task.Factory.StartNew(()=> 
            {
                while (true)
                {
                    writer.WriteLine(queue.Take());
                    writer.Flush();
                }
            });
        }

        public LogLevel LogLevel { get; set; }

        public void Debug(string message)
        {
            //Console.WriteLine(message);
            if (LogLevel <= LogLevel.Debug) queue.Add(DateTime.Now + " [DEBUG] " + message);
        }

        public void Error(Exception ex)
        {
            //Console.WriteLine(ex.Message);
            if (LogLevel <= LogLevel.Error)
            {
                queue.Add(DateTime.Now + " [ERROR] " + ex.Message);
            }
        }

        public void Error(string message)
        {
            //Console.WriteLine(message);
            if (LogLevel <= LogLevel.Error) queue.Add(DateTime.Now + " [ERROR] " + message);
        }

        public void Error(Exception ex, string message)
        {
            //Console.WriteLine(message);
            if (LogLevel <= LogLevel.Error) queue.Add(DateTime.Now + " [ERROR] " + message);
        }

        public void Info(string message)
        {
            //Console.WriteLine(message);
            if (LogLevel <= LogLevel.Info) queue.Add(DateTime.Now + " [INFO] " + message);
        }

        public void Warn(string message)
        {
            //Console.WriteLine(message);
            if (LogLevel <= LogLevel.Warn) queue.Add(DateTime.Now + " [WARN] " + message);
        }
    }
}
