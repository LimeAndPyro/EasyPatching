# EasyPatching
Makes It easier to patch Properties And Methods Using Harmony!!!

If You have any questions feel free to contact me at https://discord.gg/rosemod or contact me By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

![Example Code](https://i.imgur.com/XlgJtun.png)

Method Patches = Patches into specific method For example class Deeznuts is the typeof(deeznuts) and the methodname lets say is "inyourmom".

Post Method Patch = EasyPatchMethodPost Patches a Method And its Func After the Orig Func Is ran.
![Post Method Code](https://i.imgur.com/LDqrniE.png)

     public static void Patch()
        {
            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrivalPost");
        }

PrePost Method Patch
![Prepost Method Code](https://i.imgur.com/oybkPbD.png)

      public static void Patch()
             {
                 EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrivalPost");
             }
       
