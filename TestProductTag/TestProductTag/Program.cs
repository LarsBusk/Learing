using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProductTag
{
  class Program
  {
    private static readonly CultureInfo info = CultureInfo.InvariantCulture;
    const string format = "yyyy-MM-dd HH:mm:ss,fff";

    static void Main(string[] args)
    {
      List<Tuple<DateTime, string>> allLines = new List<Tuple<DateTime, string>>();

      allLines.AddRange(LinesFromPDxLog("PDX.MMIIPDx.txt"));
      allLines.AddRange(LinesFromProcessServer("ProcessServerHost.txt"));

      allLines.Sort(new TupleComp());

      List<string> writeLines = new List<string>();

      foreach (var allLine in allLines)
      {
        writeLines.Add($"{allLine.Item1.ToString("yyyy-MM-dd HH:mm:ss,fff")} {allLine.Item2}");
      }

      File.WriteAllLines("Result.txt", writeLines);

     // Console.Read();
    }

    private static List<Tuple<DateTime, string>> LinesFromPDxLog(string pdxLogFile)
    {
      var lines = File.ReadAllLines(pdxLogFile).ToList().FindAll(l => l.Contains("INFO  Product can"));

      List<Tuple<DateTime, string>> timeCodedLines = new List<Tuple<DateTime, string>>();

      /*foreach (var line in lines)
      {
        string dt = line.Substring(0, line.IndexOf("[") - 1);
        DateTime lineTime = DateTime.ParseExact(dt, format, info);
        string lineMessage = line.Substring(line.IndexOf("]") + 1);
        timeCodedLines.Add(new Tuple<DateTime, string>(lineTime, lineMessage));
      }*/

      timeCodedLines = lines.Select(l =>
        new Tuple<DateTime, string>(DateTime.ParseExact(l.Substring(0, l.IndexOf("[") - 1), format, info),
          l.Substring(l.IndexOf("]") + 1))).ToList();

      return timeCodedLines;
    }

    private static List<Tuple<DateTime, string>> LinesFromProcessServer(string processServerFile)
    {
      var lines = File.ReadAllLines(processServerFile).ToList().FindAll(l =>
        l.Contains("Scan is received") | l.Contains("Sample creator result is recieved in sample cache"));

      List<Tuple<DateTime, string>> timeCodedLines = new List<Tuple<DateTime, string>>();

      /*foreach (var line in lines)
      {
        string dt = line.Substring(0, line.IndexOf("[") - 1);
        DateTime lineTime = DateTime.ParseExact(dt, format, info);
        string lineMessage = line.Substring(line.IndexOf("]") + 1);
        timeCodedLines.Add(new Tuple<DateTime, string>(lineTime, lineMessage));
      }*/

      timeCodedLines = lines.Select(l =>
        new Tuple<DateTime, string>(DateTime.ParseExact(l.Substring(0, l.IndexOf("[") - 1), format, info),
          l.Substring(l.IndexOf("]") + 1))).ToList();

      return timeCodedLines;
    }
  }
}
