using System.Reflection;
using HarmonyLib;
using Verse;

namespace RecoveryPod
{
    // Token: 0x02000004 RID: 4
    [StaticConstructorOnStartup]
    internal static class HarmonyPatching
    {
        // Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00000348
        static HarmonyPatching()
        {
            new Harmony("Pelador.Rimworld.RecoveryPod").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}