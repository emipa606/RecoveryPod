using System.Reflection;
using HarmonyLib;
using Verse;

namespace RecoveryPod;

[StaticConstructorOnStartup]
internal static class HarmonyPatching
{
    static HarmonyPatching()
    {
        new Harmony("Pelador.Rimworld.RecoveryPod").PatchAll(Assembly.GetExecutingAssembly());
    }
}