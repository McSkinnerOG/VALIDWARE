using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_CSHARP
{
    public class AOB
    {
        
        public static string LocalPlayer = "80 A5 3C 35 F7 7F 00 00 20 C2 05 EF 06 02 00 00 08 00 00 00 00 00 00 00 05 00";
        public static string Options = "Minecraft.Windows.exe+0x041210C8,10,170";
        public static string FOV_Min = Options + ",10";
        public static string FOV_Max = Options + ",14";
        public static string FOV_Cur = Options + ",18";
        public static string LP_Yaw1 = LocalPlayer + ",138";
        public static string LP_Yaw2 = LocalPlayer + ",140";
        public static string LP_Pitch1 = LocalPlayer + ",13C";
        public static string LP_Pitch2 = LocalPlayer + ",144";
        //public static string LP_CameraY = LocalPlayer + ",15C";
        //public static string LP_CameraX = LocalPlayer + ",160"; 
        public static string LP_Falling = LocalPlayer + ",1D4";
        public static string LP_Jump = LocalPlayer + ",1D8";
        public static string LP_OnGround = LocalPlayer + ",1DC";
        public static string LP_StepHeight = LocalPlayer + ",238";
        public static string LP_AntiWeb1 = LocalPlayer + ",24C";
        public static string LP_AntiWeb2 = LocalPlayer + ",254";
        public static string LP_WebDrag = LocalPlayer + ",250";
        public static string LP_Name = LocalPlayer + ",9A8";
        public static string LP_IsFlying = LocalPlayer + ",A48";
        public static string LP_CanFly = LocalPlayer + ",A54";
        public static string LP_InvType = LocalPlayer + ",A60";
        public static string LP_XVelocity = LocalPlayer + ",4F0";
        public static string LP_YVelocity = LocalPlayer + ",4F4";
        public static string LP_ZVelocity = LocalPlayer + ",4F8";
        public static string LP_PosX = LocalPlayer + ",4B8";
        public static string LP_PosY = LocalPlayer + ",4BC";
        public static string LP_PosZ = LocalPlayer + ",4C0";
        public static string LP_HitboxPhaze = LocalPlayer + ",4C8";
        public static string LP_AirVelocity = LocalPlayer + ",894";
        public static string LP_Gamemode = LocalPlayer + ",1EF4";
        public static string LP_Reach = "Minecraft.Windows.exe+0x385F858";
        public static string Coordinates = "Minecraft.Windows.exe+0x6FD3C3";
    }
}
