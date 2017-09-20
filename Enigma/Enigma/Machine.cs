using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
  class Machine
  {
    
    public Rotor LeftRotor { get; set; }

    public Rotor CenterRotor { get; set; }

    public Rotor RightRotor { get; set; }

    public Reflector Reflector { get; set; }

    private Rotor rotor1;

    private Rotor rotor2;

    private Rotor rotor3;

    public Machine(int leftRoterNumber, char leftStartLetter, int centerRotorNumber, char centerStartLetter, int rightRotorNumber, char rightStartLetter)
    {
      DefineRotors();
      DefineReflector();
      SetRotorOrder(leftRoterNumber, centerRotorNumber, rightRotorNumber);
      SetStartPositions(leftStartLetter, centerStartLetter, rightStartLetter);
    }

    public char Encode(int inputChar)
    {
      int input = inputChar;
      int afterRight1 = RightRotor.Encode(input, true);
      int afterCenter1 = CenterRotor.Encode(afterRight1, true);
      int afterLeft1 = LeftRotor.Encode(afterCenter1, true);
      int afterReflector = Reflector.Reflect(afterLeft1);
      int afterLeft2 = LeftRotor.Encode(afterReflector, false);
      int afterCenter2 = CenterRotor.Encode(afterLeft2, false);
      int afterRight2 = RightRotor.Encode(afterCenter2, false);
      return Convert.ToChar(afterRight2 + 65);
    }

    public void ShiftRotors()
    {
      if (LeftRotor.ShouldRotate | CenterRotor.ShouldRotate)
      {
        LeftRotor.Rotate();
      }

      if (CenterRotor.ShouldRotate | RightRotor.ShouldRotate)
      {
        CenterRotor.Rotate();
      }

      RightRotor.Rotate();
    }

    private void SetStartPositions(char leftStartLetter, char centerStartLetter, char rightStartLetter)
    {
      LeftRotor.CurrentPosition = (int) leftStartLetter - 65;
      CenterRotor.CurrentPosition = (int) centerStartLetter - 65;
      RightRotor.CurrentPosition = (int) rightStartLetter - 65;
    }

    private void SetRotorOrder(int rotorNumber1, int rotorNumber2, int rotorNumber3)
    {
      switch (rotorNumber1)
      {
        case 1:
          LeftRotor = rotor1;
          break;
        case 2:
          LeftRotor = rotor2;
          break;
        case 3:
          LeftRotor = rotor3;
          break;
      }

      switch (rotorNumber2)
      {
        case 1:
          CenterRotor = rotor1;
          break;
        case 2:
          CenterRotor = rotor2;
          break;
        case 3:
          CenterRotor = rotor3;
          break;
      }

      switch (rotorNumber3)
      {
        case 1:
          RightRotor = rotor1;
          break;
        case 2:
          RightRotor = rotor2;
          break;
        case 3:
          RightRotor = rotor3;
          break;
      }
    }

    private void DefineRotors()
    {
      rotor1 = new Rotor();
      rotor2 = new Rotor();
      rotor3 = new Rotor();
     
      rotor1.RotorLetters.AddRange( new RotorLetter[]
      {
        new RotorLetter('A', 'E'),
        new RotorLetter('B', 'K'),
        new RotorLetter('C', 'M'),
        new RotorLetter('D', 'F'),
        new RotorLetter('E', 'L'),
        new RotorLetter('F', 'G'), 
        new RotorLetter('G', 'D'),
        new RotorLetter('H', 'Q'),
        new RotorLetter('I', 'V'),
        new RotorLetter('J', 'Z'), 
        new RotorLetter('K', 'N'), 
        new RotorLetter('L', 'T'), 
        new RotorLetter('M', 'O'), 
        new RotorLetter('N', 'W'), 
        new RotorLetter('O', 'Y'), 
        new RotorLetter('P', 'H'), 
        new RotorLetter('Q', 'X'),
        new RotorLetter('R', 'U'), 
        new RotorLetter('S', 'S'),
        new RotorLetter('T', 'P'), 
        new RotorLetter('U', 'A'),
        new RotorLetter('V', 'I'), 
        new RotorLetter('W', 'B'), 
        new RotorLetter('X', 'R'), 
        new RotorLetter('Y', 'C'), 
        new RotorLetter('Z', 'J') 
      });
      rotor1.ArrowPosition = 16;
      rotor1.CurrentPosition = 0;

      rotor2.RotorLetters.AddRange(new RotorLetter[]
      {
        new RotorLetter('A', 'A'),
        new RotorLetter('B', 'J'),
        new RotorLetter('C', 'D'),
        new RotorLetter('D', 'K'),
        new RotorLetter('E', 'S'),
        new RotorLetter('F', 'I'), 
        new RotorLetter('G', 'R'),
        new RotorLetter('H', 'U'),
        new RotorLetter('I', 'X'),
        new RotorLetter('J', 'B'), 
        new RotorLetter('K', 'L'), 
        new RotorLetter('L', 'H'), 
        new RotorLetter('M', 'W'), 
        new RotorLetter('N', 'T'), 
        new RotorLetter('O', 'M'), 
        new RotorLetter('P', 'C'), 
        new RotorLetter('Q', 'Q'),
        new RotorLetter('R', 'G'), 
        new RotorLetter('S', 'Z'),
        new RotorLetter('T', 'N'), 
        new RotorLetter('U', 'P'),
        new RotorLetter('V', 'Y'), 
        new RotorLetter('W', 'F'), 
        new RotorLetter('X', 'V'), 
        new RotorLetter('Y', 'O'), 
        new RotorLetter('Z', 'E') 
      });
      rotor2.ArrowPosition = 4;
      rotor2.CurrentPosition = 0;

      rotor3.RotorLetters.AddRange(new RotorLetter[]
      {
        new RotorLetter('A', 'B'),
        new RotorLetter('B', 'D'),
        new RotorLetter('C', 'F'),
        new RotorLetter('D', 'H'),
        new RotorLetter('E', 'J'),
        new RotorLetter('F', 'L'), 
        new RotorLetter('G', 'C'),
        new RotorLetter('H', 'P'),
        new RotorLetter('I', 'R'),
        new RotorLetter('J', 'T'), 
        new RotorLetter('K', 'X'), 
        new RotorLetter('L', 'V'), 
        new RotorLetter('M', 'Z'), 
        new RotorLetter('N', 'N'), 
        new RotorLetter('O', 'Y'), 
        new RotorLetter('P', 'E'), 
        new RotorLetter('Q', 'I'),
        new RotorLetter('R', 'W'), 
        new RotorLetter('S', 'G'),
        new RotorLetter('T', 'A'), 
        new RotorLetter('U', 'K'),
        new RotorLetter('V', 'M'), 
        new RotorLetter('W', 'U'), 
        new RotorLetter('X', 'S'), 
        new RotorLetter('Y', 'Q'), 
        new RotorLetter('Z', 'O') 
      });
      rotor3.ArrowPosition = 21;
      rotor3.CurrentPosition = 0;
    }

    private void DefineReflector()
    {
      Reflector = new Reflector();

      Reflector.ReflectorLetters.AddRange(new ReflectorLetter[]
      {
        new ReflectorLetter('A', 0, 24),
        new ReflectorLetter('B', 1, 17),
        new ReflectorLetter('C', 2, 20),
        new ReflectorLetter('D', 3, 7),
        new ReflectorLetter('E', 4, 16),
        new ReflectorLetter('F', 5, 18),
        new ReflectorLetter('G', 6, 11),
        new ReflectorLetter('I', 8, 15),
        new ReflectorLetter('J', 9, 23),
        new ReflectorLetter('K', 10, 13),
        new ReflectorLetter('M', 12, 14),
        new ReflectorLetter('T', 19, 25),
        new ReflectorLetter('V', 21,22)
      }
      );
    }
  }
}
