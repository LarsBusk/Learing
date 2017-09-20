using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
  class ReflectorLetter
  {
    public char Letter { get; set; }

    public int Position1 { get; set; }

    public int Position2 { get; set; }

    public ReflectorLetter(char letter, int position1, int position2)
    {
      this.Letter = letter;
      this.Position1 = position1;
      this.Position2 = position2;
    }
  }
}
