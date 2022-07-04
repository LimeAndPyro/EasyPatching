# EasyPatching
Makes It easier to patch Properties And Methods Using Harmony!!!

If You have any questions feel free to contact By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

![Example Code](https://i.imgur.com/XlgJtun.png)

Method Patches = Patches into specific method For example class Deeznuts is the typeof(deeznuts) and the methodname lets say is "inyourmom".

Post Method Patch = EasyPatchMethodPost Patches a Method And its Func After the Orig Func Is ran.

![Post Method Code](https://i.imgur.com/LDqrniE.png)

     public static void Patch()
        {
            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrivalPost");
        }

PrePost Method Patch = EasyPatchPropertyPre Patches A Property Before The Original Func is Ran.

![Prepost Method Code](https://i.imgur.com/oybkPbD.png)

      public static void Patch()
             {
                 EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(PlayerPatches), "OnArrivalPost");
             }
Output Function = The Function which you run your own code that will either run before or after the original code.

![Prepost Method Function Code](https://i.imgur.com/xeYbxSs.png)

Property Patching = Patches into a specific property Such as float, int, etc.

Post Property Patch = EasyPatchPropertyPost Patches A Property After The Original Func is Ran.

![Post Property Code](https://i.imgur.com/tSAd9E1.png)
     
     public static void Patch()
             {
                 EasyPatching.EasyPatchPropertyPost(typeof(PhotonPeer), "ServerAddress", typeof(PlayerPatches), "GetAddress");
             }
             
Property Prepost Patch = EasyPatchPropertyPre Patches A Property Before The Original Func is Ran

![PrePost Property Code](https://i.imgur.com/RpHe86z.png)

     public static void Patch()
             {
                 EasyPatching.EasyPatchPropertyPre(typeof(PhotonPeer), "ServerAddress", typeof(PlayerPatches), "GetAddress");
             }
IMPORTANT NOTES

-Remember to always start your patches after.

-You must use typeof cast For All Type Param.

-Its better to start all your patches in a seperete class then to start them individually on application start.

![Example start cs](https://i.imgur.com/RUc0Rxc.png)

![Example On App Start](https://i.imgur.com/GxXMSC6.png)

Thank you for Checking out my repo Much love.

       
