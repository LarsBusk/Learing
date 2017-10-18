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

    public Form1()
    {
      InitializeComponent();
    }

    private void btnFindPrimes_Click(object sender, EventArgs e)
    {
      

      //IEnumerable<int> nums = Enumerable.Range(2, maxNumber - 1);
      

      new Thread(new ThreadStart(FindPrimes)).Start();

     // PrintNums(primes);
    }

    private void FindPrimes()
    {
      int maxNumber = int.Parse(tbMaxNumber.Text);
      
      for (int i = 3; i < maxNumber; i++)
      {
        if (primes.All<int>(r => i % r != 0 && r != 1))
        {
          primes.Add(i);
          //rtbNumbers.AppendText(i.ToString() + ", ");
        }
      }

      PrintNums(primes);
    }

    private void PrintNums(IEnumerable<int> nums)
    {
      rtbNumbers.Clear();
      foreach (int num in nums)
      {
        rtbNumbers.AppendText(num.ToString() + ", ");
      }
    }
  }
}
