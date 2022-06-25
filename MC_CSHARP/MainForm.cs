using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MC_CSHARP.MODULES;
using Memory;
namespace MC_CSHARP
{
    public partial class MainForm : Form
    {
        #region DLL_IMPORTS
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
        #region MAIN_REGISTER
        public MainForm()
        {
            InitializeComponent();
            RegisterHotKey(Handle, 1, 0x0000, 'Q'); RegisterHotKey(Handle, 2, 0x0000, 'R');
            RegisterHotKey(Handle, 3, 0x0000, 'T'); RegisterHotKey(Handle, 4, 0x0000, 'Y'); 
            RegisterHotKey(Handle, 5, 0x0000, 'U'); RegisterHotKey(Handle, 6, 0x0000, 'I'); 
            RegisterHotKey(Handle, 7, 0x0000, 'O'); RegisterHotKey(Handle, 8, 0x0000, 'P'); 
            RegisterHotKey(Handle, 9, 0x0000, 'F'); RegisterHotKey(Handle, 10, 0x0000, 'G'); 
            RegisterHotKey(Handle, 11, 0x0000, 'H'); RegisterHotKey(Handle, 12, 0x0000, 'J'); 
            RegisterHotKey(Handle, 13, 0x0000, 'K'); RegisterHotKey(Handle, 14, 0x0000, 'L'); 
            RegisterHotKey(Handle, 15, 0x0000, 'Z'); RegisterHotKey(Handle, 16, 0x0000, 'X'); 
            RegisterHotKey(Handle, 17, 0x0000, 'C'); RegisterHotKey(Handle, 18, 0x0000, 'V'); 
            RegisterHotKey(Handle, 19, 0x0000, 'B'); RegisterHotKey(Handle, 20, 0x0000, 'N'); 
            RegisterHotKey(Handle, 21, 0x0000, 'M'); 
        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x0312) //our hot button recognition and function triggering
            {
                int id = msg.WParam.ToInt32();
                if (id == 1) { } if (id == 2) { } if (id == 3) { } if (id == 4) { }
                if (id == 5) { } if (id == 6) { } if (id == 7) { } if (id == 8) { }
                if (id == 9) { LOCALPLAYER.isFlying = 1; }
                if (id == 10) { } if (id == 11) { } if (id == 12) { } if (id == 13) { }
                if (id == 14) { } if (id == 15) { } if (id == 16) { } if (id == 17) { }
                if (id == 18) { } if (id == 19) { } if (id == 20) { } if (id == 21) { }
            }
            base.WndProc(ref msg);
        }
        #endregion

        public static Mem m = new Mem();
        public static bool ProcOpen = false;
        public static int processId;
        public static bool writemem = false;
        public static ConsoleKeyInfo keyInfo;
        
        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("Minecraft.Windows.exe"); 
            Thread.Sleep(100); BGWorker.ReportProgress(0);
        }
        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen) 
            {
                ProcOpenLabel.ForeColor = Color.Green; ProcOpenLabel.Text = "PROC IS LIVE";
                XValueLabel.ForeColor = Color.Green; XValueLabel.Text = m.ReadFloat(POINTER.LP_PosX).ToString();
                YValueLabel.ForeColor = Color.Green; YValueLabel.Text = m.ReadFloat(POINTER.LP_PosY).ToString();
                ZValueLabel.ForeColor = Color.Green; ZValueLabel.Text = m.ReadFloat(POINTER.LP_PosZ).ToString();
            }
            else { ProcOpenLabel.ForeColor = Color.Red; ProcOpenLabel.Text = "N/A"; return; }
            if (OnGround.Checked) { m.WriteMemory(POINTER.LP_Jump, "int", "16777473"); }
            if (Phase.Checked) { var pos = m.ReadFloat(POINTER.LP_PosY) - 1.79999065f; m.WriteMemory(POINTER.LP_HitboxPhaze, "float", pos.ToString()); }
            else { var pos2 = m.ReadFloat(POINTER.LP_PosY) + 1.79999065f; m.WriteMemory(POINTER.LP_HitboxPhaze, "float", pos2.ToString()); }
            if (CanFly.Checked) { m.WriteMemory(POINTER.LP_CanFly, "int", "1"); }
            else { m.WriteMemory(POINTER.LP_CanFly, "int", "0"); }
            if (Glide.Checked) { m.WriteMemory(POINTER.LP_YVelocity, "float", GlideTextBox.Text); } else { }
            TopMost = true;
        } 
        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { BGWorker.RunWorkerAsync(); }
        private void SetVelocityValue_Click(object sender, EventArgs e) { if (VelocityTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_YVelocity, "float", VelocityTextBox.Text); }
        private void SetReachValue_Click(object sender, EventArgs e) { if (ReachTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_Reach, "float", ReachTextBox.Text); }
        private void SetGMValue_Click(object sender, EventArgs e) { if (GMTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_Gamemode, "int", GMTextBox.Text); }
        private void SetGlideValue_Click(object sender, EventArgs e) { if (GlideTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_YVelocity, "float", GlideTextBox.Text); }
        private void VelocityTextBox_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void GMTextBox_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void ReachTextBox_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void GlideTextBox_KeyPress(object sender, KeyPressEventArgs e) { }
        private void Phase_CheckedChanged(object sender, EventArgs e) { }
        private void Glide_CheckedChanged(object sender, EventArgs e) { }
        private void OnGround_CheckedChanged(object sender, EventArgs e) { }
        private void CanFly_CheckedChanged(object sender, EventArgs e) { }
        private void Coords_CheckedChanged(object sender, EventArgs e)
        {
            if (Coords.Checked == true) { m.WriteMemory(POINTER.Coordinates, "bytes", "0x90 0x90 0x90 0x90"); }
            else if (Coords.Checked == false) { m.WriteMemory(POINTER.Coordinates, "bytes", "0x80 0x78 0x04 0x00"); }
        }

        private void VelocityLabel_Click(object sender, EventArgs e) { }
        private void GMLabel_Click(object sender, EventArgs e) { }
        private void ReachLabel_Click(object sender, EventArgs e) { }
        private void GlideLabel_Click(object sender, EventArgs e) { }
        // Mouse Stuff
        private bool mouseDown;
        private Point lastLocation;
        private void MainForm_Shown(object sender, EventArgs e) { BGWorker.RunWorkerAsync(); }
        private void MainForm_MouseDown(object sender, MouseEventArgs e) { if (e.Clicks == 1) { mouseDown = true; lastLocation = e.Location; } }
        private void MainForm_MouseMove(object sender, MouseEventArgs e) { if (mouseDown) { Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y); Update(); } }
        private void MainForm_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
    }
}
