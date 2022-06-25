namespace MC_CSHARP
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcLabel = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.SetVelocityButton = new System.Windows.Forms.Button();
            this.CanFly = new System.Windows.Forms.CheckBox();
            this.Phase = new System.Windows.Forms.CheckBox();
            this.OnGround = new System.Windows.Forms.CheckBox();
            this.Glide = new System.Windows.Forms.CheckBox();
            this.SetReachButton = new System.Windows.Forms.Button();
            this.ReachLabel = new System.Windows.Forms.Label();
            this.ReachTextBox = new System.Windows.Forms.TextBox();
            this.SetGMButton = new System.Windows.Forms.Button();
            this.GMLabel = new System.Windows.Forms.Label();
            this.GMTextBox = new System.Windows.Forms.TextBox();
            this.ZValueLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.YValueLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XValueLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.SetGlideButton = new System.Windows.Forms.Button();
            this.GlideLabel = new System.Windows.Forms.Label();
            this.GlideTextBox = new System.Windows.Forms.TextBox();
            this.Coords = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.Location = new System.Drawing.Point(1, 0);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(48, 13);
            this.ProcLabel.TabIndex = 0;
            this.ProcLabel.Text = "Process:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(49, 0);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.BackColor = System.Drawing.Color.Purple;
            this.VelocityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityTextBox.Location = new System.Drawing.Point(330, 1);
            this.VelocityTextBox.MaxLength = 10;
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(49, 20);
            this.VelocityTextBox.TabIndex = 2;
            this.VelocityTextBox.Text = "01";
            this.VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VelocityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VelocityTextBox_KeyPress);
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(264, 4);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(62, 13);
            this.VelocityLabel.TabIndex = 3;
            this.VelocityLabel.Text = "VELOCITY:";
            this.VelocityLabel.Click += new System.EventHandler(this.VelocityLabel_Click);
            // 
            // SetVelocityButton
            // 
            this.SetVelocityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetVelocityButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.SetVelocityButton.Location = new System.Drawing.Point(385, 1);
            this.SetVelocityButton.Name = "SetVelocityButton";
            this.SetVelocityButton.Size = new System.Drawing.Size(20, 20);
            this.SetVelocityButton.TabIndex = 4;
            this.SetVelocityButton.Text = "X";
            this.SetVelocityButton.UseVisualStyleBackColor = true;
            this.SetVelocityButton.Click += new System.EventHandler(this.SetVelocityValue_Click);
            // 
            // CanFly
            // 
            this.CanFly.AutoSize = true;
            this.CanFly.Location = new System.Drawing.Point(340, 231);
            this.CanFly.Name = "CanFly";
            this.CanFly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CanFly.Size = new System.Drawing.Size(61, 17);
            this.CanFly.TabIndex = 5;
            this.CanFly.Text = "Can Fly";
            this.CanFly.UseVisualStyleBackColor = true;
            this.CanFly.CheckedChanged += new System.EventHandler(this.CanFly_CheckedChanged);
            // 
            // Phase
            // 
            this.Phase.AutoSize = true;
            this.Phase.Location = new System.Drawing.Point(345, 246);
            this.Phase.Name = "Phase";
            this.Phase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phase.Size = new System.Drawing.Size(56, 17);
            this.Phase.TabIndex = 6;
            this.Phase.Text = "Phase";
            this.Phase.UseVisualStyleBackColor = true;
            this.Phase.CheckedChanged += new System.EventHandler(this.Phase_CheckedChanged);
            // 
            // OnGround
            // 
            this.OnGround.AutoSize = true;
            this.OnGround.Location = new System.Drawing.Point(326, 261);
            this.OnGround.Name = "OnGround";
            this.OnGround.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OnGround.Size = new System.Drawing.Size(75, 17);
            this.OnGround.TabIndex = 7;
            this.OnGround.Text = "OnGround";
            this.OnGround.UseVisualStyleBackColor = true;
            this.OnGround.CheckedChanged += new System.EventHandler(this.OnGround_CheckedChanged);
            // 
            // Glide
            // 
            this.Glide.AutoSize = true;
            this.Glide.Location = new System.Drawing.Point(351, 276);
            this.Glide.Name = "Glide";
            this.Glide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Glide.Size = new System.Drawing.Size(50, 17);
            this.Glide.TabIndex = 8;
            this.Glide.Text = "Glide";
            this.Glide.UseVisualStyleBackColor = true;
            this.Glide.CheckedChanged += new System.EventHandler(this.Glide_CheckedChanged);
            // 
            // SetReachButton
            // 
            this.SetReachButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetReachButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.SetReachButton.Location = new System.Drawing.Point(385, 47);
            this.SetReachButton.Name = "SetReachButton";
            this.SetReachButton.Size = new System.Drawing.Size(20, 20);
            this.SetReachButton.TabIndex = 11;
            this.SetReachButton.Text = "X";
            this.SetReachButton.UseVisualStyleBackColor = true;
            this.SetReachButton.Click += new System.EventHandler(this.SetReachValue_Click);
            // 
            // ReachLabel
            // 
            this.ReachLabel.AutoSize = true;
            this.ReachLabel.Location = new System.Drawing.Point(279, 50);
            this.ReachLabel.Name = "ReachLabel";
            this.ReachLabel.Size = new System.Drawing.Size(47, 13);
            this.ReachLabel.TabIndex = 10;
            this.ReachLabel.Text = "REACH:";
            this.ReachLabel.Click += new System.EventHandler(this.ReachLabel_Click);
            // 
            // ReachTextBox
            // 
            this.ReachTextBox.BackColor = System.Drawing.Color.Purple;
            this.ReachTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReachTextBox.Location = new System.Drawing.Point(330, 47);
            this.ReachTextBox.MaxLength = 10;
            this.ReachTextBox.Name = "ReachTextBox";
            this.ReachTextBox.Size = new System.Drawing.Size(49, 20);
            this.ReachTextBox.TabIndex = 9;
            this.ReachTextBox.Text = "03";
            this.ReachTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReachTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReachTextBox_KeyPress);
            // 
            // SetGMButton
            // 
            this.SetGMButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetGMButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.SetGMButton.Location = new System.Drawing.Point(385, 24);
            this.SetGMButton.Name = "SetGMButton";
            this.SetGMButton.Size = new System.Drawing.Size(20, 20);
            this.SetGMButton.TabIndex = 14;
            this.SetGMButton.Text = "X";
            this.SetGMButton.UseVisualStyleBackColor = true;
            this.SetGMButton.Click += new System.EventHandler(this.SetGMValue_Click);
            // 
            // GMLabel
            // 
            this.GMLabel.AutoSize = true;
            this.GMLabel.Location = new System.Drawing.Point(253, 27);
            this.GMLabel.Name = "GMLabel";
            this.GMLabel.Size = new System.Drawing.Size(73, 13);
            this.GMLabel.TabIndex = 13;
            this.GMLabel.Text = "GAMEMODE:";
            this.GMLabel.Click += new System.EventHandler(this.GMLabel_Click);
            // 
            // GMTextBox
            // 
            this.GMTextBox.BackColor = System.Drawing.Color.Purple;
            this.GMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GMTextBox.Location = new System.Drawing.Point(330, 24);
            this.GMTextBox.MaxLength = 4;
            this.GMTextBox.Name = "GMTextBox";
            this.GMTextBox.Size = new System.Drawing.Size(49, 20);
            this.GMTextBox.TabIndex = 12;
            this.GMTextBox.Text = "0";
            this.GMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GMTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GMTextBox_KeyPress);
            // 
            // ZValueLabel
            // 
            this.ZValueLabel.AutoSize = true;
            this.ZValueLabel.Location = new System.Drawing.Point(18, 280);
            this.ZValueLabel.Name = "ZValueLabel";
            this.ZValueLabel.Size = new System.Drawing.Size(27, 13);
            this.ZValueLabel.TabIndex = 16;
            this.ZValueLabel.Text = "N/A";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.ForeColor = System.Drawing.Color.Red;
            this.ZLabel.Location = new System.Drawing.Point(3, 279);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(17, 13);
            this.ZLabel.TabIndex = 15;
            this.ZLabel.Text = "Z:";
            // 
            // YValueLabel
            // 
            this.YValueLabel.AutoSize = true;
            this.YValueLabel.Location = new System.Drawing.Point(18, 266);
            this.YValueLabel.Name = "YValueLabel";
            this.YValueLabel.Size = new System.Drawing.Size(27, 13);
            this.YValueLabel.TabIndex = 18;
            this.YValueLabel.Text = "N/A";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.ForeColor = System.Drawing.Color.Red;
            this.YLabel.Location = new System.Drawing.Point(3, 265);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 17;
            this.YLabel.Text = "Y:";
            // 
            // XValueLabel
            // 
            this.XValueLabel.AutoSize = true;
            this.XValueLabel.Location = new System.Drawing.Point(18, 250);
            this.XValueLabel.Name = "XValueLabel";
            this.XValueLabel.Size = new System.Drawing.Size(27, 13);
            this.XValueLabel.TabIndex = 20;
            this.XValueLabel.Text = "N/A";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.ForeColor = System.Drawing.Color.Red;
            this.XLabel.Location = new System.Drawing.Point(3, 250);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 19;
            this.XLabel.Text = "X:";
            // 
            // SetGlideButton
            // 
            this.SetGlideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetGlideButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.SetGlideButton.Location = new System.Drawing.Point(385, 70);
            this.SetGlideButton.Name = "SetGlideButton";
            this.SetGlideButton.Size = new System.Drawing.Size(20, 20);
            this.SetGlideButton.TabIndex = 23;
            this.SetGlideButton.Text = "X";
            this.SetGlideButton.UseVisualStyleBackColor = true;
            this.SetGlideButton.Click += new System.EventHandler(this.SetGlideValue_Click);
            // 
            // GlideLabel
            // 
            this.GlideLabel.AutoSize = true;
            this.GlideLabel.Location = new System.Drawing.Point(284, 73);
            this.GlideLabel.Name = "GlideLabel";
            this.GlideLabel.Size = new System.Drawing.Size(42, 13);
            this.GlideLabel.TabIndex = 22;
            this.GlideLabel.Text = "GLIDE:";
            this.GlideLabel.Click += new System.EventHandler(this.GlideLabel_Click);
            // 
            // GlideTextBox
            // 
            this.GlideTextBox.BackColor = System.Drawing.Color.Purple;
            this.GlideTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlideTextBox.Location = new System.Drawing.Point(330, 70);
            this.GlideTextBox.MaxLength = 10;
            this.GlideTextBox.Name = "GlideTextBox";
            this.GlideTextBox.Size = new System.Drawing.Size(49, 20);
            this.GlideTextBox.TabIndex = 21;
            this.GlideTextBox.Text = "03";
            this.GlideTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GlideTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlideTextBox_KeyPress);
            // 
            // Coords
            // 
            this.Coords.AutoSize = true;
            this.Coords.Location = new System.Drawing.Point(1, 234);
            this.Coords.Name = "Coords";
            this.Coords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Coords.Size = new System.Drawing.Size(56, 17);
            this.Coords.TabIndex = 24;
            this.Coords.Text = "F-XYZ";
            this.Coords.UseVisualStyleBackColor = true;
            this.Coords.CheckedChanged += new System.EventHandler(this.Coords_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(407, 295);
            this.Controls.Add(this.Coords);
            this.Controls.Add(this.SetGlideButton);
            this.Controls.Add(this.GlideLabel);
            this.Controls.Add(this.GlideTextBox);
            this.Controls.Add(this.XValueLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YValueLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.ZValueLabel);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.SetGMButton);
            this.Controls.Add(this.GMLabel);
            this.Controls.Add(this.GMTextBox);
            this.Controls.Add(this.SetReachButton);
            this.Controls.Add(this.ReachLabel);
            this.Controls.Add(this.ReachTextBox);
            this.Controls.Add(this.Glide);
            this.Controls.Add(this.OnGround);
            this.Controls.Add(this.Phase);
            this.Controls.Add(this.CanFly);
            this.Controls.Add(this.SetVelocityButton);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.ProcLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "/////////";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Button SetVelocityButton;
        private System.Windows.Forms.CheckBox CanFly;
        private System.Windows.Forms.CheckBox Phase;
        private System.Windows.Forms.CheckBox OnGround;
        private System.Windows.Forms.CheckBox Glide;
        private System.Windows.Forms.Button SetReachButton;
        private System.Windows.Forms.Label ReachLabel;
        private System.Windows.Forms.TextBox ReachTextBox;
        private System.Windows.Forms.Button SetGMButton;
        private System.Windows.Forms.Label GMLabel;
        private System.Windows.Forms.TextBox GMTextBox;
        private System.Windows.Forms.Label ZValueLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label YValueLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XValueLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Button SetGlideButton;
        private System.Windows.Forms.Label GlideLabel;
        private System.Windows.Forms.TextBox GlideTextBox;
        private System.Windows.Forms.CheckBox Coords;
    }
}

