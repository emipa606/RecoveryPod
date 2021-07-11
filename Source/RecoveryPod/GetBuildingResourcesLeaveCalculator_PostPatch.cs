using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace RecoveryPod
{
    // Token: 0x02000003 RID: 3
    [HarmonyPatch(typeof(GenLeaving), "GetBuildingResourcesLeaveCalculator")]
    public class GetBuildingResourcesLeaveCalculator_PostPatch
    {
        // Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
        [HarmonyPostfix]
        public static void PostFix(ref Func<int, int> __result, Thing destroyedThing, ref DestroyMode mode)
        {
            if (destroyedThing.def.defName != "MSRecoveryPod" || mode != DestroyMode.Deconstruct ||
                !(destroyedThing.def.resourcesFractionWhenDeconstructed >= 1f))
            {
                return;
            }

            if (!GenLeaving.CanBuildingLeaveResources(destroyedThing, mode))
            {
                __result = _ => 0;
                return;
            }

            if (mode == DestroyMode.Deconstruct && destroyedThing is Frame)
            {
                mode = DestroyMode.Cancel;
                return;
            }

            if (mode == DestroyMode.Deconstruct)
            {
                __result = count => count;
            }
        }
    }
}