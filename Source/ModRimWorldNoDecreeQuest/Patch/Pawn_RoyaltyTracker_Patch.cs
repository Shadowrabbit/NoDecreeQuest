using HarmonyLib;
using JetBrains.Annotations;
using RimWorld;
using SR.ModRimWorld.NoDecreeQuest;
using Verse;

namespace SR.NDQ.Patch
{
	public static class PawnRoyaltyTrackerPatch
	{
		[HarmonyPatch(typeof(Pawn_RoyaltyTracker), "IssueDecree", typeof(bool), typeof(string))]
		private static class PawnRoyaltyTrackerPatch1
		{
			[HarmonyPrefix]
			[UsedImplicitly]
			private static bool Prefix(bool causedByMentalBreak, string mentalBreakReason = null)
			{
				Log.Warning("法令颁布");
				return !UIWindowMain.instance.modSetting.isOpenMod;
			}
		}
	}
}
