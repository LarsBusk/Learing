namespace Enigma
{
  partial class MainForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbInput = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbOutput = new System.Windows.Forms.TextBox();
      this.btnEncrypt = new System.Windows.Forms.Button();
      this.tbLeftLetter = new System.Windows.Forms.TextBox();
      this.tbCenterLetter = new System.Windows.Forms.TextBox();
      this.tbRightLetter = new System.Windows.Forms.TextBox();
      this.btnSetRotors = new System.Windows.Forms.Button();
      this.rbCenterMustRotate = new System.Windows.Forms.RadioButton();
      this.rbLeftMustRotate = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.updRight = new System.Windows.Forms.NumericUpDown();
      this.updCenterRotor = new System.Windows.Forms.NumericUpDown();
      this.updLeftRotor = new System.Windows.Forms.NumericUpDown();
      this.btnQ = new System.Windows.Forms.Button();
      this.btnA = new System.Windows.Forms.Button();
      this.btnP = new System.Windows.Forms.Button();
      this.btnW = new System.Windows.Forms.Button();
      this.btnS = new System.Windows.Forms.Button();
      this.btnE = new System.Windows.Forms.Button();
      this.btnR = new System.Windows.Forms.Button();
      this.btnF = new System.Windows.Forms.Button();
      this.btnZ = new System.Windows.Forms.Button();
      this.btnI = new System.Windows.Forms.Button();
      this.btnU = new System.Windows.Forms.Button();
      this.btnT = new System.Windows.Forms.Button();
      this.btnH = new System.Windows.Forms.Button();
      this.btnG = new System.Windows.Forms.Button();
      this.btnD = new System.Windows.Forms.Button();
      this.btnK = new System.Windows.Forms.Button();
      this.btnY = new System.Windows.Forms.Button();
      this.btnJ = new System.Windows.Forms.Button();
      this.btnX = new System.Windows.Forms.Button();
      this.btnC = new System.Windows.Forms.Button();
      this.btnV = new System.Windows.Forms.Button();
      this.btnB = new System.Windows.Forms.Button();
      this.btnN = new System.Windows.Forms.Button();
      this.btnM = new System.Windows.Forms.Button();
      this.btnL = new System.Windows.Forms.Button();
      this.btnSpace = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnO = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updRight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updCenterRotor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updLeftRotor)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(66, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Linke Rotor";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(158, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Center Rotor";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(255, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Reichte Rotor";
      // 
      // tbInput
      // 
      this.tbInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbInput.Location = new System.Drawing.Point(13, 177);
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(344, 20);
      this.tbInput.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 161);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Input";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 122);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(39, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Output";
      // 
      // tbOutput
      // 
      this.tbOutput.Location = new System.Drawing.Point(12, 138);
      this.tbOutput.Name = "tbOutput";
      this.tbOutput.ReadOnly = true;
      this.tbOutput.Size = new System.Drawing.Size(345, 20);
      this.tbOutput.TabIndex = 9;
      // 
      // btnEncrypt
      // 
      this.btnEncrypt.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnEncrypt.Location = new System.Drawing.Point(374, 175);
      this.btnEncrypt.Name = "btnEncrypt";
      this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
      this.btnEncrypt.TabIndex = 10;
      this.btnEncrypt.Text = "Encrypt";
      this.btnEncrypt.UseVisualStyleBackColor = true;
      this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
      // 
      // tbLeftLetter
      // 
      this.tbLeftLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbLeftLetter.Location = new System.Drawing.Point(62, 64);
      this.tbLeftLetter.Name = "tbLeftLetter";
      this.tbLeftLetter.Size = new System.Drawing.Size(66, 20);
      this.tbLeftLetter.TabIndex = 11;
      this.tbLeftLetter.Text = "M";
      // 
      // tbCenterLetter
      // 
      this.tbCenterLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbCenterLetter.Location = new System.Drawing.Point(154, 64);
      this.tbCenterLetter.Name = "tbCenterLetter";
      this.tbCenterLetter.Size = new System.Drawing.Size(71, 20);
      this.tbCenterLetter.TabIndex = 12;
      this.tbCenterLetter.Text = "C";
      // 
      // tbRightLetter
      // 
      this.tbRightLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.tbRightLetter.Location = new System.Drawing.Point(251, 65);
      this.tbRightLetter.Name = "tbRightLetter";
      this.tbRightLetter.Size = new System.Drawing.Size(65, 20);
      this.tbRightLetter.TabIndex = 13;
      this.tbRightLetter.Text = "K";
      // 
      // btnSetRotors
      // 
      this.btnSetRotors.Location = new System.Drawing.Point(362, 62);
      this.btnSetRotors.Name = "btnSetRotors";
      this.btnSetRotors.Size = new System.Drawing.Size(75, 23);
      this.btnSetRotors.TabIndex = 14;
      this.btnSetRotors.Text = "Set";
      this.btnSetRotors.UseVisualStyleBackColor = true;
      this.btnSetRotors.Click += new System.EventHandler(this.btnSetRotors_Click);
      // 
      // rbCenterMustRotate
      // 
      this.rbCenterMustRotate.AutoSize = true;
      this.rbCenterMustRotate.Enabled = false;
      this.rbCenterMustRotate.Location = new System.Drawing.Point(231, 67);
      this.rbCenterMustRotate.Name = "rbCenterMustRotate";
      this.rbCenterMustRotate.Size = new System.Drawing.Size(14, 13);
      this.rbCenterMustRotate.TabIndex = 15;
      this.rbCenterMustRotate.TabStop = true;
      this.rbCenterMustRotate.UseVisualStyleBackColor = true;
      // 
      // rbLeftMustRotate
      // 
      this.rbLeftMustRotate.AutoSize = true;
      this.rbLeftMustRotate.Enabled = false;
      this.rbLeftMustRotate.Location = new System.Drawing.Point(134, 67);
      this.rbLeftMustRotate.Name = "rbLeftMustRotate";
      this.rbLeftMustRotate.Size = new System.Drawing.Size(14, 13);
      this.rbLeftMustRotate.TabIndex = 16;
      this.rbLeftMustRotate.TabStop = true;
      this.rbLeftMustRotate.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.updRight);
      this.groupBox1.Controls.Add(this.updCenterRotor);
      this.groupBox1.Controls.Add(this.updLeftRotor);
      this.groupBox1.Controls.Add(this.rbLeftMustRotate);
      this.groupBox1.Controls.Add(this.rbCenterMustRotate);
      this.groupBox1.Controls.Add(this.btnSetRotors);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.tbRightLetter);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.tbCenterLetter);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tbLeftLetter);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(453, 100);
      this.groupBox1.TabIndex = 17;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Rotoren";
      // 
      // updRight
      // 
      this.updRight.Location = new System.Drawing.Point(251, 38);
      this.updRight.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.updRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.updRight.Name = "updRight";
      this.updRight.Size = new System.Drawing.Size(65, 20);
      this.updRight.TabIndex = 19;
      this.updRight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.updRight.ValueChanged += new System.EventHandler(this.rotor_ValueChanged);
      // 
      // updCenterRotor
      // 
      this.updCenterRotor.Location = new System.Drawing.Point(154, 38);
      this.updCenterRotor.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.updCenterRotor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.updCenterRotor.Name = "updCenterRotor";
      this.updCenterRotor.Size = new System.Drawing.Size(71, 20);
      this.updCenterRotor.TabIndex = 18;
      this.updCenterRotor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.updCenterRotor.ValueChanged += new System.EventHandler(this.rotor_ValueChanged);
      // 
      // updLeftRotor
      // 
      this.updLeftRotor.Location = new System.Drawing.Point(62, 38);
      this.updLeftRotor.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.updLeftRotor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.updLeftRotor.Name = "updLeftRotor";
      this.updLeftRotor.Size = new System.Drawing.Size(66, 20);
      this.updLeftRotor.TabIndex = 17;
      this.updLeftRotor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.updLeftRotor.ValueChanged += new System.EventHandler(this.rotor_ValueChanged);
      // 
      // btnQ
      // 
      this.btnQ.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnQ.Location = new System.Drawing.Point(13, 245);
      this.btnQ.Name = "btnQ";
      this.btnQ.Size = new System.Drawing.Size(33, 33);
      this.btnQ.TabIndex = 18;
      this.btnQ.Text = "Q";
      this.btnQ.UseVisualStyleBackColor = true;
      this.btnQ.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnA
      // 
      this.btnA.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnA.Location = new System.Drawing.Point(33, 284);
      this.btnA.Name = "btnA";
      this.btnA.Size = new System.Drawing.Size(33, 33);
      this.btnA.TabIndex = 19;
      this.btnA.Text = "A";
      this.btnA.UseVisualStyleBackColor = true;
      this.btnA.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnP
      // 
      this.btnP.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnP.Location = new System.Drawing.Point(13, 323);
      this.btnP.Name = "btnP";
      this.btnP.Size = new System.Drawing.Size(33, 33);
      this.btnP.TabIndex = 20;
      this.btnP.Text = "P";
      this.btnP.UseVisualStyleBackColor = true;
      this.btnP.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnW
      // 
      this.btnW.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnW.Location = new System.Drawing.Point(52, 245);
      this.btnW.Name = "btnW";
      this.btnW.Size = new System.Drawing.Size(33, 33);
      this.btnW.TabIndex = 21;
      this.btnW.Text = "W";
      this.btnW.UseVisualStyleBackColor = true;
      this.btnW.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnS
      // 
      this.btnS.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnS.Location = new System.Drawing.Point(72, 284);
      this.btnS.Name = "btnS";
      this.btnS.Size = new System.Drawing.Size(33, 33);
      this.btnS.TabIndex = 22;
      this.btnS.Text = "S";
      this.btnS.UseVisualStyleBackColor = true;
      this.btnS.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnE
      // 
      this.btnE.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnE.Location = new System.Drawing.Point(91, 245);
      this.btnE.Name = "btnE";
      this.btnE.Size = new System.Drawing.Size(33, 33);
      this.btnE.TabIndex = 23;
      this.btnE.Text = "E";
      this.btnE.UseVisualStyleBackColor = true;
      this.btnE.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnR
      // 
      this.btnR.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnR.Location = new System.Drawing.Point(130, 245);
      this.btnR.Name = "btnR";
      this.btnR.Size = new System.Drawing.Size(33, 33);
      this.btnR.TabIndex = 24;
      this.btnR.Text = "R";
      this.btnR.UseVisualStyleBackColor = true;
      this.btnR.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnF
      // 
      this.btnF.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnF.Location = new System.Drawing.Point(150, 284);
      this.btnF.Name = "btnF";
      this.btnF.Size = new System.Drawing.Size(33, 33);
      this.btnF.TabIndex = 25;
      this.btnF.Text = "F";
      this.btnF.UseVisualStyleBackColor = true;
      this.btnF.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnZ
      // 
      this.btnZ.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnZ.Location = new System.Drawing.Point(208, 245);
      this.btnZ.Name = "btnZ";
      this.btnZ.Size = new System.Drawing.Size(33, 33);
      this.btnZ.TabIndex = 26;
      this.btnZ.Text = "Z";
      this.btnZ.UseVisualStyleBackColor = true;
      this.btnZ.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnI
      // 
      this.btnI.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnI.Location = new System.Drawing.Point(286, 245);
      this.btnI.Name = "btnI";
      this.btnI.Size = new System.Drawing.Size(33, 33);
      this.btnI.TabIndex = 27;
      this.btnI.Text = "I";
      this.btnI.UseVisualStyleBackColor = true;
      this.btnI.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnU
      // 
      this.btnU.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnU.Location = new System.Drawing.Point(247, 245);
      this.btnU.Name = "btnU";
      this.btnU.Size = new System.Drawing.Size(33, 33);
      this.btnU.TabIndex = 28;
      this.btnU.Text = "U";
      this.btnU.UseVisualStyleBackColor = true;
      this.btnU.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnT
      // 
      this.btnT.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnT.Location = new System.Drawing.Point(169, 245);
      this.btnT.Name = "btnT";
      this.btnT.Size = new System.Drawing.Size(33, 33);
      this.btnT.TabIndex = 29;
      this.btnT.Text = "T";
      this.btnT.UseVisualStyleBackColor = true;
      this.btnT.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnH
      // 
      this.btnH.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnH.Location = new System.Drawing.Point(228, 284);
      this.btnH.Name = "btnH";
      this.btnH.Size = new System.Drawing.Size(33, 33);
      this.btnH.TabIndex = 30;
      this.btnH.Text = "H";
      this.btnH.UseVisualStyleBackColor = true;
      this.btnH.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnG
      // 
      this.btnG.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnG.Location = new System.Drawing.Point(189, 284);
      this.btnG.Name = "btnG";
      this.btnG.Size = new System.Drawing.Size(33, 33);
      this.btnG.TabIndex = 31;
      this.btnG.Text = "G";
      this.btnG.UseVisualStyleBackColor = true;
      this.btnG.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnD
      // 
      this.btnD.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnD.Location = new System.Drawing.Point(111, 284);
      this.btnD.Name = "btnD";
      this.btnD.Size = new System.Drawing.Size(33, 33);
      this.btnD.TabIndex = 32;
      this.btnD.Text = "D";
      this.btnD.UseVisualStyleBackColor = true;
      this.btnD.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnK
      // 
      this.btnK.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnK.Location = new System.Drawing.Point(306, 284);
      this.btnK.Name = "btnK";
      this.btnK.Size = new System.Drawing.Size(33, 33);
      this.btnK.TabIndex = 33;
      this.btnK.Text = "K";
      this.btnK.UseVisualStyleBackColor = true;
      this.btnK.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnY
      // 
      this.btnY.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnY.Location = new System.Drawing.Point(52, 323);
      this.btnY.Name = "btnY";
      this.btnY.Size = new System.Drawing.Size(33, 33);
      this.btnY.TabIndex = 34;
      this.btnY.Text = "Y";
      this.btnY.UseVisualStyleBackColor = true;
      this.btnY.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnJ
      // 
      this.btnJ.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnJ.Location = new System.Drawing.Point(267, 284);
      this.btnJ.Name = "btnJ";
      this.btnJ.Size = new System.Drawing.Size(33, 33);
      this.btnJ.TabIndex = 36;
      this.btnJ.Text = "J";
      this.btnJ.UseVisualStyleBackColor = true;
      this.btnJ.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnX
      // 
      this.btnX.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnX.Location = new System.Drawing.Point(91, 323);
      this.btnX.Name = "btnX";
      this.btnX.Size = new System.Drawing.Size(33, 33);
      this.btnX.TabIndex = 37;
      this.btnX.Text = "X";
      this.btnX.UseVisualStyleBackColor = true;
      this.btnX.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnC
      // 
      this.btnC.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnC.Location = new System.Drawing.Point(130, 323);
      this.btnC.Name = "btnC";
      this.btnC.Size = new System.Drawing.Size(33, 33);
      this.btnC.TabIndex = 38;
      this.btnC.Text = "C";
      this.btnC.UseVisualStyleBackColor = true;
      this.btnC.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnV
      // 
      this.btnV.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnV.Location = new System.Drawing.Point(169, 323);
      this.btnV.Name = "btnV";
      this.btnV.Size = new System.Drawing.Size(33, 33);
      this.btnV.TabIndex = 39;
      this.btnV.Text = "V";
      this.btnV.UseVisualStyleBackColor = true;
      this.btnV.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnB
      // 
      this.btnB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnB.Location = new System.Drawing.Point(208, 323);
      this.btnB.Name = "btnB";
      this.btnB.Size = new System.Drawing.Size(33, 33);
      this.btnB.TabIndex = 40;
      this.btnB.Text = "B";
      this.btnB.UseVisualStyleBackColor = true;
      this.btnB.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnN
      // 
      this.btnN.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnN.Location = new System.Drawing.Point(247, 323);
      this.btnN.Name = "btnN";
      this.btnN.Size = new System.Drawing.Size(33, 33);
      this.btnN.TabIndex = 41;
      this.btnN.Text = "N";
      this.btnN.UseVisualStyleBackColor = true;
      this.btnN.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnM
      // 
      this.btnM.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnM.Location = new System.Drawing.Point(286, 323);
      this.btnM.Name = "btnM";
      this.btnM.Size = new System.Drawing.Size(33, 33);
      this.btnM.TabIndex = 42;
      this.btnM.Text = "M";
      this.btnM.UseVisualStyleBackColor = true;
      this.btnM.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnL
      // 
      this.btnL.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnL.Location = new System.Drawing.Point(325, 323);
      this.btnL.Name = "btnL";
      this.btnL.Size = new System.Drawing.Size(33, 33);
      this.btnL.TabIndex = 43;
      this.btnL.Text = "L";
      this.btnL.UseVisualStyleBackColor = true;
      this.btnL.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // btnSpace
      // 
      this.btnSpace.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnSpace.Location = new System.Drawing.Point(13, 362);
      this.btnSpace.Name = "btnSpace";
      this.btnSpace.Size = new System.Drawing.Size(344, 33);
      this.btnSpace.TabIndex = 44;
      this.btnSpace.UseVisualStyleBackColor = true;
      this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(374, 135);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 45;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnO
      // 
      this.btnO.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Enigma.Properties.Settings.Default, "ButtonState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.btnO.Enabled = global::Enigma.Properties.Settings.Default.ButtonState;
      this.btnO.Location = new System.Drawing.Point(325, 245);
      this.btnO.Name = "btnO";
      this.btnO.Size = new System.Drawing.Size(33, 33);
      this.btnO.TabIndex = 35;
      this.btnO.Text = "O";
      this.btnO.UseVisualStyleBackColor = true;
      this.btnO.Click += new System.EventHandler(this.KeyBordKeys_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(509, 448);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnSpace);
      this.Controls.Add(this.btnL);
      this.Controls.Add(this.btnM);
      this.Controls.Add(this.btnN);
      this.Controls.Add(this.btnB);
      this.Controls.Add(this.btnV);
      this.Controls.Add(this.btnC);
      this.Controls.Add(this.btnX);
      this.Controls.Add(this.btnJ);
      this.Controls.Add(this.btnO);
      this.Controls.Add(this.btnY);
      this.Controls.Add(this.btnK);
      this.Controls.Add(this.btnD);
      this.Controls.Add(this.btnG);
      this.Controls.Add(this.btnH);
      this.Controls.Add(this.btnT);
      this.Controls.Add(this.btnU);
      this.Controls.Add(this.btnI);
      this.Controls.Add(this.btnZ);
      this.Controls.Add(this.btnF);
      this.Controls.Add(this.btnR);
      this.Controls.Add(this.btnE);
      this.Controls.Add(this.btnS);
      this.Controls.Add(this.btnW);
      this.Controls.Add(this.btnP);
      this.Controls.Add(this.btnA);
      this.Controls.Add(this.btnQ);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnEncrypt);
      this.Controls.Add(this.tbOutput);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbInput);
      this.Name = "MainForm";
      this.Text = "Enigma";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updRight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updCenterRotor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updLeftRotor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbInput;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbOutput;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.TextBox tbLeftLetter;
    private System.Windows.Forms.TextBox tbCenterLetter;
    private System.Windows.Forms.TextBox tbRightLetter;
    private System.Windows.Forms.Button btnSetRotors;
    private System.Windows.Forms.RadioButton rbCenterMustRotate;
    private System.Windows.Forms.RadioButton rbLeftMustRotate;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnQ;
    private System.Windows.Forms.Button btnA;
    private System.Windows.Forms.Button btnP;
    private System.Windows.Forms.Button btnW;
    private System.Windows.Forms.Button btnS;
    private System.Windows.Forms.Button btnE;
    private System.Windows.Forms.Button btnR;
    private System.Windows.Forms.Button btnF;
    private System.Windows.Forms.Button btnZ;
    private System.Windows.Forms.Button btnI;
    private System.Windows.Forms.Button btnU;
    private System.Windows.Forms.Button btnT;
    private System.Windows.Forms.Button btnH;
    private System.Windows.Forms.Button btnG;
    private System.Windows.Forms.Button btnD;
    private System.Windows.Forms.Button btnK;
    private System.Windows.Forms.Button btnY;
    private System.Windows.Forms.Button btnO;
    private System.Windows.Forms.Button btnJ;
    private System.Windows.Forms.Button btnX;
    private System.Windows.Forms.Button btnC;
    private System.Windows.Forms.Button btnV;
    private System.Windows.Forms.Button btnB;
    private System.Windows.Forms.Button btnN;
    private System.Windows.Forms.Button btnM;
    private System.Windows.Forms.Button btnL;
    private System.Windows.Forms.Button btnSpace;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.NumericUpDown updRight;
    private System.Windows.Forms.NumericUpDown updCenterRotor;
    private System.Windows.Forms.NumericUpDown updLeftRotor;
  }
}

