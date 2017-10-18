namespace Primes
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnFindPrimes = new System.Windows.Forms.Button();
      this.tbMaxNumber = new System.Windows.Forms.TextBox();
      this.rtbNumbers = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // btnFindPrimes
      // 
      this.btnFindPrimes.Location = new System.Drawing.Point(371, 316);
      this.btnFindPrimes.Name = "btnFindPrimes";
      this.btnFindPrimes.Size = new System.Drawing.Size(75, 23);
      this.btnFindPrimes.TabIndex = 0;
      this.btnFindPrimes.Text = "Find tal";
      this.btnFindPrimes.UseVisualStyleBackColor = true;
      this.btnFindPrimes.Click += new System.EventHandler(this.btnFindPrimes_Click);
      // 
      // tbMaxNumber
      // 
      this.tbMaxNumber.Location = new System.Drawing.Point(346, 279);
      this.tbMaxNumber.Name = "tbMaxNumber";
      this.tbMaxNumber.Size = new System.Drawing.Size(100, 20);
      this.tbMaxNumber.TabIndex = 1;
      // 
      // rtbNumbers
      // 
      this.rtbNumbers.Location = new System.Drawing.Point(16, 15);
      this.rtbNumbers.Name = "rtbNumbers";
      this.rtbNumbers.Size = new System.Drawing.Size(313, 324);
      this.rtbNumbers.TabIndex = 2;
      this.rtbNumbers.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(458, 351);
      this.Controls.Add(this.rtbNumbers);
      this.Controls.Add(this.tbMaxNumber);
      this.Controls.Add(this.btnFindPrimes);
      this.Name = "Form1";
      this.Text = "Primtal";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnFindPrimes;
    private System.Windows.Forms.TextBox tbMaxNumber;
    private System.Windows.Forms.RichTextBox rtbNumbers;
  }
}

