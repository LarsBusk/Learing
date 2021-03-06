﻿namespace Drawing {
    partial class Mandelbrot {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelbrot));
      this.generatePatternButton = new System.Windows.Forms.Button();
      this.pixelStepTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.xMinCheckBox = new System.Windows.Forms.TextBox();
      this.xMaxCheckBox = new System.Windows.Forms.TextBox();
      this.zoomCheckbox = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.iterationCountTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.yMinCheckBox = new System.Windows.Forms.TextBox();
      this.yMaxCheckBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.zoomTextBox = new System.Windows.Forms.TextBox();
      this.statusLabel = new System.Windows.Forms.Label();
      this.undoButton = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.stopwatchLabel = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.favouritesComboBox = new System.Windows.Forms.ComboBox();
      this.openFavouritesButton = new System.Windows.Forms.Button();
      this.addToFavouritesButton = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.fileNameLabel = new System.Windows.Forms.Label();
      this.saveImageTextBox = new System.Windows.Forms.TextBox();
      this.saveImageButton = new System.Windows.Forms.Button();
      this.aboutLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // generatePatternButton
      // 
      this.generatePatternButton.BackColor = System.Drawing.SystemColors.Control;
      this.generatePatternButton.Location = new System.Drawing.Point(86, 422);
      this.generatePatternButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.generatePatternButton.Name = "generatePatternButton";
      this.generatePatternButton.Size = new System.Drawing.Size(122, 88);
      this.generatePatternButton.TabIndex = 0;
      this.generatePatternButton.Text = "Generate Pattern";
      this.generatePatternButton.UseVisualStyleBackColor = false;
      this.generatePatternButton.Click += new System.EventHandler(this.generate_Click);
      // 
      // pixelStepTextBox
      // 
      this.pixelStepTextBox.Location = new System.Drawing.Point(27, 57);
      this.pixelStepTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pixelStepTextBox.Name = "pixelStepTextBox";
      this.pixelStepTextBox.Size = new System.Drawing.Size(154, 26);
      this.pixelStepTextBox.TabIndex = 1;
      this.pixelStepTextBox.Text = "1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(24, 35);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Pixel step";
      // 
      // xMinCheckBox
      // 
      this.xMinCheckBox.Location = new System.Drawing.Point(21, 283);
      this.xMinCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.xMinCheckBox.Name = "xMinCheckBox";
      this.xMinCheckBox.Size = new System.Drawing.Size(82, 26);
      this.xMinCheckBox.TabIndex = 13;
      this.xMinCheckBox.Text = "-2";
      // 
      // xMaxCheckBox
      // 
      this.xMaxCheckBox.Location = new System.Drawing.Point(110, 283);
      this.xMaxCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.xMaxCheckBox.Name = "xMaxCheckBox";
      this.xMaxCheckBox.Size = new System.Drawing.Size(82, 26);
      this.xMaxCheckBox.TabIndex = 14;
      this.xMaxCheckBox.Text = "1";
      // 
      // zoomCheckbox
      // 
      this.zoomCheckbox.AutoSize = true;
      this.zoomCheckbox.Location = new System.Drawing.Point(26, 388);
      this.zoomCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.zoomCheckbox.Name = "zoomCheckbox";
      this.zoomCheckbox.Size = new System.Drawing.Size(76, 24);
      this.zoomCheckbox.TabIndex = 15;
      this.zoomCheckbox.Text = "Zoom";
      this.zoomCheckbox.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 102);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Iterations";
      // 
      // iterationCountTextBox
      // 
      this.iterationCountTextBox.Location = new System.Drawing.Point(28, 126);
      this.iterationCountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.iterationCountTextBox.Name = "iterationCountTextBox";
      this.iterationCountTextBox.Size = new System.Drawing.Size(152, 26);
      this.iterationCountTextBox.TabIndex = 5;
      this.iterationCountTextBox.Text = "85";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(24, 183);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "yMin";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(110, 183);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "yMax";
      // 
      // yMinCheckBox
      // 
      this.yMinCheckBox.Location = new System.Drawing.Point(21, 208);
      this.yMinCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.yMinCheckBox.Name = "yMinCheckBox";
      this.yMinCheckBox.Size = new System.Drawing.Size(82, 26);
      this.yMinCheckBox.TabIndex = 9;
      this.yMinCheckBox.Text = "-1";
      // 
      // yMaxCheckBox
      // 
      this.yMaxCheckBox.Location = new System.Drawing.Point(110, 208);
      this.yMaxCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.yMaxCheckBox.Name = "yMaxCheckBox";
      this.yMaxCheckBox.Size = new System.Drawing.Size(82, 26);
      this.yMaxCheckBox.TabIndex = 10;
      this.yMaxCheckBox.Text = "1";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 257);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 20);
      this.label5.TabIndex = 11;
      this.label5.Text = "xMin";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(111, 258);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(45, 20);
      this.label6.TabIndex = 12;
      this.label6.Text = "xMax";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.zoomTextBox);
      this.groupBox1.Controls.Add(this.statusLabel);
      this.groupBox1.Controls.Add(this.undoButton);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.generatePatternButton);
      this.groupBox1.Controls.Add(this.pixelStepTextBox);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.zoomCheckbox);
      this.groupBox1.Controls.Add(this.iterationCountTextBox);
      this.groupBox1.Controls.Add(this.xMaxCheckBox);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.xMinCheckBox);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.yMinCheckBox);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.yMaxCheckBox);
      this.groupBox1.Location = new System.Drawing.Point(1266, 5);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Size = new System.Drawing.Size(216, 558);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Configuration";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(20, 325);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(91, 20);
      this.label8.TabIndex = 26;
      this.label8.Text = "Zoom scale";
      // 
      // zoomTextBox
      // 
      this.zoomTextBox.Location = new System.Drawing.Point(21, 348);
      this.zoomTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.zoomTextBox.Name = "zoomTextBox";
      this.zoomTextBox.Size = new System.Drawing.Size(160, 26);
      this.zoomTextBox.TabIndex = 25;
      this.zoomTextBox.Text = "7";
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Location = new System.Drawing.Point(10, 523);
      this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(60, 20);
      this.statusLabel.TabIndex = 24;
      this.statusLabel.Text = "Status:";
      // 
      // undoButton
      // 
      this.undoButton.BackColor = System.Drawing.Color.Transparent;
      this.undoButton.BackgroundImage = global::Drawing.Properties.Resources.undo_4_xxl;
      this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.undoButton.ImageKey = "(none)";
      this.undoButton.Location = new System.Drawing.Point(15, 434);
      this.undoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.undoButton.Name = "undoButton";
      this.undoButton.Size = new System.Drawing.Size(62, 63);
      this.undoButton.TabIndex = 23;
      this.undoButton.UseVisualStyleBackColor = false;
      this.undoButton.Click += new System.EventHandler(this.undo_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.stopwatchLabel);
      this.groupBox2.Location = new System.Drawing.Point(1266, 791);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Size = new System.Drawing.Size(216, 77);
      this.groupBox2.TabIndex = 20;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Timer";
      // 
      // stopwatchLabel
      // 
      this.stopwatchLabel.AutoSize = true;
      this.stopwatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stopwatchLabel.Location = new System.Drawing.Point(14, 25);
      this.stopwatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.stopwatchLabel.Name = "stopwatchLabel";
      this.stopwatchLabel.Size = new System.Drawing.Size(0, 29);
      this.stopwatchLabel.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label7);
      this.groupBox3.Controls.Add(this.favouritesComboBox);
      this.groupBox3.Controls.Add(this.openFavouritesButton);
      this.groupBox3.Controls.Add(this.addToFavouritesButton);
      this.groupBox3.Location = new System.Drawing.Point(1266, 562);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox3.Size = new System.Drawing.Size(216, 232);
      this.groupBox3.TabIndex = 21;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Favourites";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(46, 102);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(130, 20);
      this.label7.TabIndex = 3;
      this.label7.Text = "List of Favourites";
      // 
      // favouritesComboBox
      // 
      this.favouritesComboBox.FormattingEnabled = true;
      this.favouritesComboBox.Location = new System.Drawing.Point(20, 132);
      this.favouritesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.favouritesComboBox.Name = "favouritesComboBox";
      this.favouritesComboBox.Size = new System.Drawing.Size(180, 28);
      this.favouritesComboBox.TabIndex = 2;
      this.favouritesComboBox.DropDown += new System.EventHandler(this.favouritesComboBox_DropDown);
      // 
      // openFavouritesButton
      // 
      this.openFavouritesButton.Location = new System.Drawing.Point(42, 178);
      this.openFavouritesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.openFavouritesButton.Name = "openFavouritesButton";
      this.openFavouritesButton.Size = new System.Drawing.Size(134, 35);
      this.openFavouritesButton.TabIndex = 1;
      this.openFavouritesButton.Text = "Open Favourite";
      this.openFavouritesButton.UseVisualStyleBackColor = true;
      this.openFavouritesButton.Click += new System.EventHandler(this.openFavourites_Click);
      // 
      // addToFavouritesButton
      // 
      this.addToFavouritesButton.Location = new System.Drawing.Point(15, 34);
      this.addToFavouritesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.addToFavouritesButton.Name = "addToFavouritesButton";
      this.addToFavouritesButton.Size = new System.Drawing.Size(192, 51);
      this.addToFavouritesButton.TabIndex = 0;
      this.addToFavouritesButton.Text = "Add This to Favourites";
      this.addToFavouritesButton.UseVisualStyleBackColor = true;
      this.addToFavouritesButton.Click += new System.EventHandler(this.addToFavourites_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.fileNameLabel);
      this.groupBox4.Controls.Add(this.saveImageTextBox);
      this.groupBox4.Controls.Add(this.saveImageButton);
      this.groupBox4.Location = new System.Drawing.Point(1266, 866);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox4.Size = new System.Drawing.Size(216, 132);
      this.groupBox4.TabIndex = 22;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Export";
      // 
      // fileNameLabel
      // 
      this.fileNameLabel.AutoSize = true;
      this.fileNameLabel.Location = new System.Drawing.Point(32, 28);
      this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.fileNameLabel.Name = "fileNameLabel";
      this.fileNameLabel.Size = new System.Drawing.Size(78, 20);
      this.fileNameLabel.TabIndex = 2;
      this.fileNameLabel.Text = "File name";
      // 
      // saveImageTextBox
      // 
      this.saveImageTextBox.Location = new System.Drawing.Point(33, 54);
      this.saveImageTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.saveImageTextBox.Name = "saveImageTextBox";
      this.saveImageTextBox.Size = new System.Drawing.Size(148, 26);
      this.saveImageTextBox.TabIndex = 1;
      this.saveImageTextBox.Text = "myImage";
      // 
      // saveImageButton
      // 
      this.saveImageButton.Location = new System.Drawing.Point(42, 91);
      this.saveImageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.saveImageButton.Name = "saveImageButton";
      this.saveImageButton.Size = new System.Drawing.Size(134, 35);
      this.saveImageButton.TabIndex = 0;
      this.saveImageButton.Text = "Save image";
      this.saveImageButton.UseVisualStyleBackColor = true;
      this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
      // 
      // aboutLabel
      // 
      this.aboutLabel.AutoSize = true;
      this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.aboutLabel.Location = new System.Drawing.Point(-2, 978);
      this.aboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.aboutLabel.Name = "aboutLabel";
      this.aboutLabel.Size = new System.Drawing.Size(52, 20);
      this.aboutLabel.TabIndex = 23;
      this.aboutLabel.Text = "About";
      this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
      // 
      // Mandelbrot
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1484, 1050);
      this.Controls.Add(this.aboutLabel);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Mandelbrot";
      this.Text = "Mandelbrot";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Mandelbrot_Paint);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseClickOnForm);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpOnForm);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generatePatternButton;
        private System.Windows.Forms.TextBox pixelStepTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xMinCheckBox;
        private System.Windows.Forms.TextBox xMaxCheckBox;
        private System.Windows.Forms.CheckBox zoomCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationCountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yMinCheckBox;
        private System.Windows.Forms.TextBox yMaxCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addToFavouritesButton;
        private System.Windows.Forms.Button openFavouritesButton;
        private System.Windows.Forms.ComboBox favouritesComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zoomTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox saveImageTextBox;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Label aboutLabel;
    }
}

