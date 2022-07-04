using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;
using ExitGames.Client.Photon;

namespace Discreet.SDK.Patching
{
    public class PlayerPatches
    {
        public static void Patch()
        {
            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrival");
            EasyPatching.EasyPatchPropertyPre(typeof(PhotonPeer), "ServerAddress", typeof(PlayerPatches), "GetAddress");
        }
            
        public static void OnArrival(VRC.Player param_1)
        {   
            Console.WriteLine($"{param_1.prop_APIUser_0.displayName} Has Joined The Lobby");
        }

        //note this is a dummy func i dont know if it will work lmao
        public static void GetAddress(ref string __result)
        {
            Console.WriteLine(__result);
        }
    }
}
