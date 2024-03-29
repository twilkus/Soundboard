﻿namespace Soundboard
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
            this.components = new System.ComponentModel.Container();
            Soundboard.Player player1 = new Soundboard.Player();
            Soundboard.Player player2 = new Soundboard.Player();
            Soundboard.Player player3 = new Soundboard.Player();
            Soundboard.Player player4 = new Soundboard.Player();
            Soundboard.Player player18 = new Soundboard.Player();
            Soundboard.Player player17 = new Soundboard.Player();
            Soundboard.Player player13 = new Soundboard.Player();
            Soundboard.Player player14 = new Soundboard.Player();
            Soundboard.Player player15 = new Soundboard.Player();
            Soundboard.Player player16 = new Soundboard.Player();
            Soundboard.Player player9 = new Soundboard.Player();
            Soundboard.Player player10 = new Soundboard.Player();
            Soundboard.Player player11 = new Soundboard.Player();
            Soundboard.Player player12 = new Soundboard.Player();
            Soundboard.Player player5 = new Soundboard.Player();
            Soundboard.Player player6 = new Soundboard.Player();
            Soundboard.Player player7 = new Soundboard.Player();
            Soundboard.Player player8 = new Soundboard.Player();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new Soundboard.SoundButton();
            this.button2 = new Soundboard.SoundButton();
            this.button3 = new Soundboard.SoundButton();
            this.button4 = new Soundboard.SoundButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.SetSoundFolderButton = new Soundboard.SoundButton();
            this.KillSoundButton = new Soundboard.SoundButton();
            this.button5 = new Soundboard.SoundButton();
            this.button6 = new Soundboard.SoundButton();
            this.button7 = new Soundboard.SoundButton();
            this.button8 = new Soundboard.SoundButton();
            this.button9 = new Soundboard.SoundButton();
            this.button10 = new Soundboard.SoundButton();
            this.button11 = new Soundboard.SoundButton();
            this.button12 = new Soundboard.SoundButton();
            this.button13 = new Soundboard.SoundButton();
            this.button14 = new Soundboard.SoundButton();
            this.button15 = new Soundboard.SoundButton();
            this.button16 = new Soundboard.SoundButton();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "pathButton1";
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Path = null;
            this.button1.Player = player1;
            this.button1.PlayPicture = null;
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 0;
            this.button1.Tag = "";
            this.button1.Text = "(Empty)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SoundButton_Click);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "pathButton2";
            this.button2.Location = new System.Drawing.Point(119, 13);
            this.button2.Name = "button2";
            this.button2.Path = null;
            this.button2.Player = player2;
            this.button2.PlayPicture = null;
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 1;
            this.button2.Tag = "";
            this.button2.Text = "(Empty)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SoundButton_Click);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "pathButton3";
            this.button3.Location = new System.Drawing.Point(225, 13);
            this.button3.Name = "button3";
            this.button3.Path = null;
            this.button3.Player = player3;
            this.button3.PlayPicture = null;
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 2;
            this.button3.Tag = "";
            this.button3.Text = "(Empty)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SoundButton_Click);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "pathButton4";
            this.button4.Location = new System.Drawing.Point(331, 13);
            this.button4.Name = "button4";
            this.button4.Path = null;
            this.button4.Player = player4;
            this.button4.PlayPicture = null;
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 3;
            this.button4.Tag = "";
            this.button4.Text = "(Empty)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SoundButton_Click);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // SetSoundFolderButton
            // 
            this.SetSoundFolderButton.Location = new System.Drawing.Point(13, 277);
            this.SetSoundFolderButton.Name = "SetSoundFolderButton";
            this.SetSoundFolderButton.Path = null;
            this.SetSoundFolderButton.Player = player18;
            this.SetSoundFolderButton.PlayPicture = null;
            this.SetSoundFolderButton.Size = new System.Drawing.Size(100, 34);
            this.SetSoundFolderButton.TabIndex = 17;
            this.SetSoundFolderButton.Text = "Set Sound Folder Path";
            this.SetSoundFolderButton.UseVisualStyleBackColor = true;
            this.SetSoundFolderButton.Click += new System.EventHandler(this.SetSoundFolderButton_Click);
            // 
            // KillSoundButton
            // 
            this.KillSoundButton.BackColor = System.Drawing.Color.Red;
            this.KillSoundButton.Location = new System.Drawing.Point(331, 289);
            this.KillSoundButton.Name = "KillSoundButton";
            this.KillSoundButton.Path = null;
            this.KillSoundButton.Player = player17;
            this.KillSoundButton.PlayPicture = null;
            this.KillSoundButton.Size = new System.Drawing.Size(100, 82);
            this.KillSoundButton.TabIndex = 18;
            this.KillSoundButton.Text = "Stop All Sounds";
            this.KillSoundButton.UseVisualStyleBackColor = false;
            this.KillSoundButton.Click += new System.EventHandler(this.KillSoundButton_Click);
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "pathButton5";
            this.button5.Location = new System.Drawing.Point(13, 79);
            this.button5.Name = "button5";
            this.button5.Path = null;
            this.button5.Player = player13;
            this.button5.PlayPicture = null;
            this.button5.Size = new System.Drawing.Size(100, 60);
            this.button5.TabIndex = 22;
            this.button5.Tag = "";
            this.button5.Text = "(Empty)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SoundButton_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "pathButton6";
            this.button6.Location = new System.Drawing.Point(119, 79);
            this.button6.Name = "button6";
            this.button6.Path = null;
            this.button6.Player = player14;
            this.button6.PlayPicture = null;
            this.button6.Size = new System.Drawing.Size(100, 60);
            this.button6.TabIndex = 21;
            this.button6.Tag = "";
            this.button6.Text = "(Empty)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SoundButton_Click);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button7
            // 
            this.button7.AccessibleDescription = "pathButton7";
            this.button7.Location = new System.Drawing.Point(225, 79);
            this.button7.Name = "button7";
            this.button7.Path = null;
            this.button7.Player = player15;
            this.button7.PlayPicture = null;
            this.button7.Size = new System.Drawing.Size(100, 60);
            this.button7.TabIndex = 20;
            this.button7.Tag = "";
            this.button7.Text = "(Empty)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SoundButton_Click);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button8
            // 
            this.button8.AccessibleDescription = "pathButton8";
            this.button8.Location = new System.Drawing.Point(331, 79);
            this.button8.Name = "button8";
            this.button8.Path = null;
            this.button8.Player = player16;
            this.button8.PlayPicture = null;
            this.button8.Size = new System.Drawing.Size(100, 60);
            this.button8.TabIndex = 19;
            this.button8.Tag = "";
            this.button8.Text = "(Empty)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SoundButton_Click);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button9
            // 
            this.button9.AccessibleDescription = "pathButton9";
            this.button9.Location = new System.Drawing.Point(13, 145);
            this.button9.Name = "button9";
            this.button9.Path = null;
            this.button9.Player = player9;
            this.button9.PlayPicture = null;
            this.button9.Size = new System.Drawing.Size(100, 60);
            this.button9.TabIndex = 26;
            this.button9.Tag = "";
            this.button9.Text = "(Empty)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SoundButton_Click);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button10
            // 
            this.button10.AccessibleDescription = "pathButton10";
            this.button10.Location = new System.Drawing.Point(119, 145);
            this.button10.Name = "button10";
            this.button10.Path = null;
            this.button10.Player = player10;
            this.button10.PlayPicture = null;
            this.button10.Size = new System.Drawing.Size(100, 60);
            this.button10.TabIndex = 25;
            this.button10.Tag = "";
            this.button10.Text = "(Empty)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SoundButton_Click);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button11
            // 
            this.button11.AccessibleDescription = "pathButton11";
            this.button11.Location = new System.Drawing.Point(225, 145);
            this.button11.Name = "button11";
            this.button11.Path = null;
            this.button11.Player = player11;
            this.button11.PlayPicture = null;
            this.button11.Size = new System.Drawing.Size(100, 60);
            this.button11.TabIndex = 24;
            this.button11.Tag = "";
            this.button11.Text = "(Empty)";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.SoundButton_Click);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button12
            // 
            this.button12.AccessibleDescription = "pathButton12";
            this.button12.Location = new System.Drawing.Point(331, 145);
            this.button12.Name = "button12";
            this.button12.Path = null;
            this.button12.Player = player12;
            this.button12.PlayPicture = null;
            this.button12.Size = new System.Drawing.Size(100, 60);
            this.button12.TabIndex = 23;
            this.button12.Tag = "";
            this.button12.Text = "(Empty)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SoundButton_Click);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button13
            // 
            this.button13.AccessibleDescription = "pathButton13";
            this.button13.Location = new System.Drawing.Point(13, 211);
            this.button13.Name = "button13";
            this.button13.Path = null;
            this.button13.Player = player5;
            this.button13.PlayPicture = null;
            this.button13.Size = new System.Drawing.Size(100, 60);
            this.button13.TabIndex = 30;
            this.button13.Tag = "";
            this.button13.Text = "(Empty)";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SoundButton_Click);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button14
            // 
            this.button14.AccessibleDescription = "pathButton14";
            this.button14.Location = new System.Drawing.Point(119, 211);
            this.button14.Name = "button14";
            this.button14.Path = null;
            this.button14.Player = player6;
            this.button14.PlayPicture = null;
            this.button14.Size = new System.Drawing.Size(100, 60);
            this.button14.TabIndex = 29;
            this.button14.Tag = "";
            this.button14.Text = "(Empty)";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.SoundButton_Click);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button15
            // 
            this.button15.AccessibleDescription = "pathButton15";
            this.button15.Location = new System.Drawing.Point(225, 211);
            this.button15.Name = "button15";
            this.button15.Path = null;
            this.button15.Player = player7;
            this.button15.PlayPicture = null;
            this.button15.Size = new System.Drawing.Size(100, 60);
            this.button15.TabIndex = 28;
            this.button15.Tag = "";
            this.button15.Text = "(Empty)";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SoundButton_Click);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button16
            // 
            this.button16.AccessibleDescription = "pathButton16";
            this.button16.Location = new System.Drawing.Point(331, 211);
            this.button16.Name = "button16";
            this.button16.Path = null;
            this.button16.Player = player8;
            this.button16.PlayPicture = null;
            this.button16.Size = new System.Drawing.Size(100, 60);
            this.button16.TabIndex = 27;
            this.button16.Tag = "";
            this.button16.Text = "(Empty)";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.SoundButton_Click);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(13, 314);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(91, 13);
            this.labelFolderPath.TabIndex = 31;
            this.labelFolderPath.Text = "No Path Selected";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(9, 330);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 34);
            this.trackBar1.TabIndex = 32;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Clear All Buttons";
            this.menuItem2.Click += new System.EventHandler(this.ClearAllButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.KillSoundButton);
            this.Controls.Add(this.SetSoundFolderButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Soundboard";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoundButton button1;
        private SoundButton button2;
        private SoundButton button3;
        private SoundButton button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private SoundButton button13;
        private SoundButton button14;
        private SoundButton button15;
        private SoundButton button16;
        private SoundButton button9;
        private SoundButton button10;
        private SoundButton button11;
        private SoundButton button12;
        private SoundButton button5;
        private SoundButton button6;
        private SoundButton button7;
        private SoundButton button8;
        private SoundButton KillSoundButton;
        private SoundButton SetSoundFolderButton;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label1;
    }
}

