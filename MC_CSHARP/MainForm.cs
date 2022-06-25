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
        public MainForm()
        {
            InitializeComponent();
            RegisterHotKey(Handle, 1, 0x0002, '1');
            RegisterHotKey(Handle, 2, 0x0000, 'F'); 
        }
        #region DllImports
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x0312) //our hot button recognition and function triggering
            {
                int id = msg.WParam.ToInt32();
                if (id == 1)
                { //our designated ID to execute
                    execFunction(); //our function to execute
                }
                if (id == 2)
                { //our designated ID to execute
                    LOCALPLAYER.isFlying = 1; //our second function to execute
                }
            }
            base.WndProc(ref msg);
        }
        void execFunction()
        {
            MessageBox.Show("You pressed the hotkey!");
        }
        void execSecondFunction()
        {
            MessageBox.Show("You pressed the 2nd hotkey!");
        }
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public static Mem m = new Mem();
        public bool ProcOpen = false;
        public static int processId;
        public static bool writemem = false;
        public static bool Flying = false;
        public static ConsoleKeyInfo keyInfo;
        
        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        { 
            ProcOpen = m.OpenProcess("Minecraft.Windows.exe"); 
            Thread.Sleep(100); BGWorker.ReportProgress(0);
        }
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey); 
        private static readonly int VK_F = 0x46; //This is the F key
        private static readonly int VK_G = 0x47; //This is the G key
        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen) 
            { 
                ProcOpenLabel.ForeColor = Color.Green; ProcOpenLabel.Text = "Game Found";
                XValueLabel.ForeColor = Color.Green; XValueLabel.Text = m.ReadFloat(POINTER.LP_PosX).ToString();
                YValueLabel.ForeColor = Color.Green; YValueLabel.Text = m.ReadFloat(POINTER.LP_PosY).ToString();
                ZValueLabel.ForeColor = Color.Green; ZValueLabel.Text = m.ReadFloat(POINTER.LP_PosZ).ToString();
            }
            else { ProcOpenLabel.ForeColor = Color.Red; ProcOpenLabel.Text = "N/A"; return; }
            short Flight_KeyState = GetAsyncKeyState(VK_F);
            short Glide_KeyState = GetAsyncKeyState(VK_G);
            //Check if the MSB is set. If so, then the key is pressed.
            bool Flight_IsPressed = ((Flight_KeyState >> 15) & 0x0001) == 0x0001;
            bool Glide_IsPressed = ((Glide_KeyState >> 15) & 0x0001) == 0x0001;
            //Check if the LSB is set. If so, then the key was pressed since
            //the last call to GetAsyncKeyState
            bool Flight_UnprocessedPress = ((Flight_KeyState >> 0) & 0x0001) == 0x0001;
            bool Glide_UnprocessedPress = ((Glide_KeyState >> 0) & 0x0001) == 0x0001;
            if (Flight_IsPressed) { CanFly.Checked = !CanFly.Checked; }
            if (Flight_UnprocessedPress) { }
            if (Glide_IsPressed) { Glide.Checked = !Glide.Checked; }
            if (Glide_UnprocessedPress) { }

            if (OnGround.Checked) { m.WriteMemory(POINTER.LP_Jump, "int", "16777473"); }
            //if (Coords.Checked) { m.WriteMemory(POINTER.Coordinates, "bytes", "0x90 0x90 0x90 0x90"); } 
            //else { if (m.ReadByte(POINTER.Coordinates).ToString() == "144"){ m.WriteMemory(POINTER.Coordinates, "bytes", "0x80 0x78 0x04 0x00"); } }
            if (Phase.Checked) { var pos = m.ReadFloat(POINTER.LP_PosY) - 1.79999065f; m.WriteMemory(POINTER.LP_HitboxPhaze, "float", pos.ToString()); } 
            else { var pos2 = m.ReadFloat(POINTER.LP_PosY) + 1.79999065f; m.WriteMemory(POINTER.LP_HitboxPhaze, "float", pos2.ToString()); }
            if (CanFly.Checked) { m.WriteMemory(POINTER.LP_CanFly, "int", "1"); }
            else { m.WriteMemory(POINTER.LP_CanFly, "int", "0"); }  
            if (Glide.Checked) { m.WriteMemory(POINTER.LP_YVelocity, "float", GlideTextBox.Text); } else { }


            
            TopMost = true;
        } 
        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { BGWorker.RunWorkerAsync(); } 
        private void SetVelocityValue_Click(object sender, EventArgs e)
        { if (VelocityTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_YVelocity, "float", VelocityTextBox.Text); }
        private void SetReachValue_Click(object sender, EventArgs e)
        { if (ReachTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_Reach, "float", ReachTextBox.Text); }
        private void SetGMValue_Click(object sender, EventArgs e)
        { if (GMTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_Gamemode, "int", GMTextBox.Text); }
        private void SetGlideValue_Click(object sender, EventArgs e)
        { if (GlideTextBox.Text != "" && ProcOpen) m.WriteMemory(POINTER.LP_YVelocity, "float", GlideTextBox.Text); }
        private void VelocityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void GMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void ReachTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }

        private void GlideTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void VelocityLabel_Click(object sender, EventArgs e) { }
        private void GMLabel_Click(object sender, EventArgs e) { }
        private void ReachLabel_Click(object sender, EventArgs e) { }
        private void GlideLabel_Click(object sender, EventArgs e) { }
        private void Phase_CheckedChanged(object sender, EventArgs e) { } 
        private void Glide_CheckedChanged(object sender, EventArgs e) { } 
        private void OnGround_CheckedChanged(object sender, EventArgs e) { } 
        private void CanFly_CheckedChanged(object sender, EventArgs e) 
        {
             
        }
        private void Coords_CheckedChanged(object sender, EventArgs e)
        {
            if (Coords.Checked == true) { m.WriteMemory(POINTER.Coordinates, "bytes", "0x90 0x90 0x90 0x90"); }
            else if(Coords.Checked == false){ m.WriteMemory(POINTER.Coordinates, "bytes", "0x80 0x78 0x04 0x00"); }
        }

        private bool mouseDown;
        private Point lastLocation;
        private void MainForm_Shown(object sender, EventArgs e) { BGWorker.RunWorkerAsync(); }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        { if (e.Clicks == 1) { mouseDown = true; lastLocation = e.Location; } }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        { if (mouseDown) { Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y); Update(); } }
        private void MainForm_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }

        
    }
}
