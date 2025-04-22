using MelonLoader;
using HarmonyLib;
using UnityEngine;

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
        }
    }
}