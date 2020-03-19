using HarmonyLib;
using System;
using SR.NDQ.Mod;
using RimWorld;
namespace SR.NDQ.Patch
{
    public class Pawn_RoyaltyTracker_Patch
    {
        [HarmonyPatch(typeof(Pawn_RoyaltyTracker), "IssueDecree", new Type[] { typeof(bool), typeof(string) })]
        class Pawn_RoyaltyTracker_Patch1
        {
            [HarmonyPrefix]
            static bool Prefix(bool causedByMentalBreak, string mentalBreakReason = null)
            {
                NDQMain.instance.SRLog("IssueDecree");
                if (!NDQMain.instance.modSetting.isOpenMod)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
