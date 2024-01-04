using GameNetcodeStuff;
using HarmonyLib;

namespace InfiniteSprint.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]

        static void InfiniteSprint_Patch(ref float ___sprintMeter, ref float ___jumpForce)
        {

            ___sprintMeter = 1f;



        }

    }
}