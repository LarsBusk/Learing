using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProductTag
{
  public class TupleComp : IComparer<Tuple<DateTime, string>>
  {
    public int Compare(Tuple<DateTime, string> x, Tuple<DateTime, string> y)
    {
      return x.Item1.CompareTo(y.Item1);
    }
  }
}
