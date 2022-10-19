using HarmonyLib;
using RimWorld;
using Verse;

namespace RecoveryPod;

[HarmonyPatch(typeof(FuelingPortUtility), "FuelingPortGiverAtFuelingPortCell")]
public class FuelingPortGiverAtFuelingPortCell_Patch
{
    [HarmonyPrefix]
    [HarmonyPriority(800)]
    public static bool PreFix(ref Building __result, IntVec3 c, Map map)
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