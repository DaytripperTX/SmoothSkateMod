using MelonLoader;
using HarmonyLib;
using UnityEngine;

[assembly: MelonInfo(typeof(SmoothSkateMod.SmoothSkate), "SmoothSkate", "1.0.0", "volcomtx")]
[assembly: MelonGame("TVGS", "Schedule One")]

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