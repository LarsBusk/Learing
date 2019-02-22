using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LoggingTest
{
  class Program
  {
    private static readonly ILog log = LogManager.GetLogger(typeof(Program));
    static void Main(string[] args)
    {
      log.Debug("Debug log line");
      log.Info("Info level log line.");
      log.Warn("Warning level log line");
      log.Error("Error level log line");
      log.Fatal("Fatal level log line.");

      Console.Read();
    }
  }
}
