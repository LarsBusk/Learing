namespace StateMachine
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
      this.Connectbutton = new System.Windows.Forms.Button();
      this.Stopbutton = new System.Windows.Forms.Button();
      this.Standbybutton = new System.Windows.Forms.Button();
      this.Measurebutton = new System.Windows.Forms.Button();
      this.Disconnectedlabel = new System.Windows.Forms.Label();
      this.Stoplabel = new System.Windows.Forms.Label();
      this.Standbylabel = new System.Windows.Forms.Label();
      this.Measurelabel = new System.Windows.Forms.Label();
      this.SetErrorbutton = new System.Windows.Forms.Button();
      this.ClearErrorbutton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Connectbutton
      // 
      this.Connectbutton.Location = new System.Drawing.Point(39, 42);
      this.Connectbutton.Name = "Connectbutton";
      this.Connectbutton.Size = new System.Drawing.Size(92, 23);
      this.Connectbutton.TabIndex = 0;
      this.Connectbutton.Text = "Disconnect";
      this.Connectbutton.UseVisualStyleBackColor = true;
      this.Connectbutton.Click += new System.EventHandler(this.Disconnectbutton_Click);
      // 
      // Stopbutton
      // 
      this.Stopbutton.Location = new System.Drawing.Point(39, 71);
      this.Stopbutton.Name = "Stopbutton";
      this.Stopbutton.Size = new System.Drawing.Size(92, 23);
      this.Stopbutton.TabIndex = 1;
      this.Stopbutton.Text = "Stop";
      this.Stopbutton.UseVisualStyleBackColor = true;
      this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
      // 
      // Standbybutton
      // 
      this.Standbybutton.Location = new System.Drawing.Point(39, 100);
      this.Standbybutton.Name = "Standbybutton";
      this.Standbybutton.Size = new System.Drawing.Size(92, 23);
      this.Standbybutton.TabIndex = 2;
      this.Standbybutton.Text = "Standby";
      this.Standbybutton.UseVisualStyleBackColor = true;
      this.Standbybutton.Click += new System.EventHandler(this.Standbybutton_Click);
      // 
      // Measurebutton
      // 
      this.Measurebutton.Location = new System.Drawing.Point(39, 129);
      this.Measurebutton.Name = "Measurebutton";
      this.Measurebutton.Size = new System.Drawing.Size(92, 23);
      this.Measurebutton.TabIndex = 3;
      this.Measurebutton.Text = "Measure";
      this.Measurebutton.UseVisualStyleBackColor = true;
      this.Measurebutton.Click += new System.EventHandler(this.Measurebutton_Click);
      // 
      // Disconnectedlabel
      // 
      this.Disconnectedlabel.AutoSize = true;
      this.Disconnectedlabel.Location = new System.Drawing.Point(151, 42);
      this.Disconnectedlabel.Name = "Disconnectedlabel";
      this.Disconnectedlabel.Size = new System.Drawing.Size(94, 17);
      this.Disconnectedlabel.TabIndex = 4;
      this.Disconnectedlabel.Text = "Disconnected";
      // 
      // Stoplabel
      // 
      this.Stoplabel.AutoSize = true;
      this.Stoplabel.Location = new System.Drawing.Point(151, 71);
      this.Stoplabel.Name = "Stoplabel";
      this.Stoplabel.Size = new System.Drawing.Size(37, 17);
      this.Stoplabel.TabIndex = 5;
      this.Stoplabel.Text = "Stop";
      // 
      // Standbylabel
      // 
      this.Standbylabel.AutoSize = true;
      this.Standbylabel.Location = new System.Drawing.Point(151, 100);
      this.Standbylabel.Name = "Standbylabel";
      this.Standbylabel.Size = new System.Drawing.Size(60, 17);
      this.Standbylabel.TabIndex = 6;
      this.Standbylabel.Text = "Standby";
      // 
      // Measurelabel
      // 
      this.Measurelabel.AutoSize = true;
      this.Measurelabel.Location = new System.Drawing.Point(151, 129);
      this.Measurelabel.Name = "Measurelabel";
      this.Measurelabel.Size = new System.Drawing.Size(63, 17);
      this.Measurelabel.TabIndex = 7;
      this.Measurelabel.Text = "Measure";
      // 
      // SetErrorbutton
      // 
      this.SetErrorbutton.Location = new System.Drawing.Point(15, 25);
      this.SetErrorbutton.Name = "SetErrorbutton";
      this.SetErrorbutton.Size = new System.Drawing.Size(75, 23);
      this.SetErrorbutton.TabIndex = 8;
      this.SetErrorbutton.Text = "Set";
      this.SetErrorbutton.UseVisualStyleBackColor = true;
      this.SetErrorbutton.Click += new System.EventHandler(this.SetErrorbutton_Click);
      // 
      // ClearErrorbutton
      // 
      this.ClearErrorbutton.Location = new System.Drawing.Point(15, 54);
      this.ClearErrorbutton.Name = "ClearErrorbutton";
      this.ClearErrorbutton.Size = new System.Drawing.Size(75, 23);
      this.ClearErrorbutton.TabIndex = 9;
      this.ClearErrorbutton.Text = "Clear";
      this.ClearErrorbutton.UseVisualStyleBackColor = true;
      this.ClearErrorbutton.Click += new System.EventHandler(this.ClearErrorbutton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.SetErrorbutton);
      this.groupBox1.Controls.Add(this.ClearErrorbutton);
      this.groupBox1.Location = new System.Drawing.Point(285, 46);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(130, 100);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Error";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 211);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.Measurelabel);
      this.Controls.Add(this.Standbylabel);
      this.Controls.Add(this.Stoplabel);
      this.Controls.Add(this.Disconnectedlabel);
      this.Controls.Add(this.Measurebutton);
      this.Controls.Add(this.Standbybutton);
      this.Controls.Add(this.Stopbutton);
      this.Controls.Add(this.Connectbutton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Button Standbybutton;
        private System.Windows.Forms.Button Measurebutton;
        private System.Windows.Forms.Label Disconnectedlabel;
        private System.Windows.Forms.Label Stoplabel;
        private System.Windows.Forms.Label Standbylabel;
        private System.Windows.Forms.Label Measurelabel;
    private System.Windows.Forms.Button SetErrorbutton;
    private System.Windows.Forms.Button ClearErrorbutton;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

