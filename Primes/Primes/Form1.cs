using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primes
{
  public partial class Form1 : Form
  {
    List<int> primes = new List<int>() { 2, 3 };

    private delegate void AddNumberToListCallBack(int number);

    public Form1()
    {
      InitializeComponent();
    }

    private void btnFindPrimes_Click(object sender, EventArgs e)
    {
      rtbNumbers.Clear();
      primes.Clear();
      new Thread(new ThreadStart(FindPrimes)).Start();
    }

    private void FindPrimes()
    {
      int maxNumber = int.Parse(tbMaxNumber.Text);
      
      for (int i = 3; i < maxNumber; i++)
      {
        if (primes.All(r => i % r != 0 && r != 1))
        {
          primes.Add(i);
          PrintNums(i);
        }
      }
    }

    private void PrintNums(int number)
    {
      if (rtbNumbers.InvokeRequired)
      {
        AddNumberToListCallBack d = PrintNums;
        this.Invoke(d, new object[] {number});
        return;
      }

      rtbNumbers.AppendText($"{number}, ");
    }
  }
}
