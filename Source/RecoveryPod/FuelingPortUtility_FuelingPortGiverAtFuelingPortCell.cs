using HarmonyLib;
using RimWorld;
using Verse;

namespace RecoveryPod;

[HarmonyPatch(typeof(FuelingPortUtility), nameof(FuelingPortUtility.FuelingPortGiverAtFuelingPortCell))]
public static class FuelingPortUtility_FuelingPortGiverAtFuelingPortCell
{
    [HarmonyPriority(800)]
    public static bool Prefix(ref Building __result, IntVec3 c, Map map)
    {
        var pod = c.GetFirstBuilding(map);
        if (pod == null || pod.def.defName != "MSRecoveryPod")
        {
            return true;
        }

        __result = pod;
        return false;
    }
}