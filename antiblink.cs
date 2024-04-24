using BepInEx;
using HarmonyLib;
using UnityEngine;
using BoplFixedMath;

namespace AntiBlink
{
    [BepInPlugin("com.Luman.AntiBlink", "AntiBlink", "1.0.0")]
    public class AntiBlink : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("com.Luman.AntiBlink");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(QuantumTunnel), "DelayedInit")]
    public class Patch_DelayedInit
    {
        static void Prefix(ref Fix delay)
        {
            delay = Fix.Zero; 
        }
    }
}
