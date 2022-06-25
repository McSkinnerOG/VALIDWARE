using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_CSHARP.MODULES
{
    public class LOCALPLAYER
    {
        public static byte isFlying
        {
            get { return (byte)MainForm.m.ReadByte(POINTER.LP_IsFlying); }
            set { MainForm.m.WriteMemory(POINTER.LP_IsFlying, "byte", "1"); }
        }
    }
}
