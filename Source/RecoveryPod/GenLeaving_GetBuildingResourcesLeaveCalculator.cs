using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace RecoveryPod;

[HarmonyPatch(typeof(GenLeaving), "GetBuildingResourcesLeaveCalculator")]
public static class GenLeaving_GetBuildingResourcesLeaveCalculator
{
    public static void Postfix(ref Func<int, int> __result, Thing destroyedThing, ref DestroyMode mode)
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

        switch (mode)
        {
            case DestroyMode.Deconstruct when destroyedThing is Frame:
                mode = DestroyMode.Cancel;
                return;
            case DestroyMode.Deconstruct:
                __result = count => count;
                break;
        }
    }
}