using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2CppScheduleOne.Skating;

[assembly: MelonInfo(typeof(SmoothSkateMod.SmoothSkate), "SmoothSkate", "0.1.0", "volcomtx")]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace SmoothSkateMod
{
    public class SmoothSkate : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
            MelonLogger.Msg("SmoothSkate loaded. Ride smooth!");

            foreach (var method in typeof(Skateboard).GetMethods())
            {
                MelonLogger.Msg("Found method: " + method.Name);
            }
        }
}

    [HarmonyPatch(typeof(Skateboard), "GetSurfaceSmoothness")]
    public static class Skateboard_GetSurfaceSmoothness_Patch
    {
        static bool Prefix(ref float __result)
        {
            __result = 1f;
            MelonLogger.Msg("setting smoothness to 1f");
            return false; // Skip original method
        }
    }
}