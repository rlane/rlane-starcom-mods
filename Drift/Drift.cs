using Harmony;
using UnityEngine;
using System.Reflection;
using System;

namespace Drift
{
    [HarmonyPatch(typeof(Ship), "RefreshBuild")]
    internal class Ship_RefreshBuild
    {
        private static void Postfix(Ship __instance)
        {
            __instance.Rigid.drag = 0.1f;
        }
    }

    static class Main
    {
        static void Load()
        {
            var harmony = HarmonyInstance.Create("com.github.rlane.rlane-starcom-mods.drift");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
