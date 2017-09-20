using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
  class Reflector
  {
    public List<ReflectorLetter> ReflectorLetters { get; set; }

    public Reflector()
    {
      ReflectorLetters = new List<ReflectorLetter>();
    }

    public int Reflect(int inputPosition)
    {
      foreach (ReflectorLetter reflectorLetter in ReflectorLetters)
      {
        if (inputPosition == reflectorLetter.Position1)
        {
          return reflectorLetter.Position2;
        }

        if (inputPosition==reflectorLetter.Position2)
        {
          return reflectorLetter.Position1;
        }
      }

      return -1;
    }
  }
}
