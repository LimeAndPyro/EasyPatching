# EasyPatching
Makes It easier to patch Properties And Methods Using Harmony!!!

If You have any questions feel free to contact me at https://discord.gg/rosemod or contact me By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

![Example Code](https://i.imgur.com/XlgJtun.png)

HOW TO USE

     public static void Patch()
        {
            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrival");
        }
            
