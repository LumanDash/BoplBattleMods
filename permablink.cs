using BepInEx;
using HarmonyLib;
using UnityEngine;
using BoplFixedMath;

namespace PermaBlink 
{
    [BepInPlugin("com.Luman.PermaBlink", "PermaBlink", "1.0.0")]
    public class PermaBlink : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("com.Luman.PermaBlink");
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
