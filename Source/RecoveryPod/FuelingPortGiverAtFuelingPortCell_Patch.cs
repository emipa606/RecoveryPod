using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace RecoveryPod
{
	// Token: 0x02000002 RID: 2
	[HarmonyPatch(typeof(FuelingPortUtility), "FuelingPortGiverAtFuelingPortCell")]
	public class FuelingPortGiverAtFuelingPortCell_Patch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[HarmonyPrefix]
		[HarmonyPriority(800)]
		public static bool PreFix(ref Building __result, IntVec3 c, Map map)
		{
			Building pod = c.GetFirstBuilding(map);
			if (pod != null && pod.def.defName == "MSRecoveryPod")
			{
				__result = pod;
				return false;
			}
			return true;
		}
	}
}
