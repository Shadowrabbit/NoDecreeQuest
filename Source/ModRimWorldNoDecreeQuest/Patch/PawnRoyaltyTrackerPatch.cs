// ******************************************************************
//       /\ /|       @file       PawnRoyaltyTrackerPatch.cs
//       \ V/        @brief      皇家追踪器
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-08 19:52:20
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************
using HarmonyLib;
using JetBrains.Annotations;
using RimWorld;
using Verse;

namespace SR.ModRimWorld.NoDecreeQuest
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
                return false;
            }
        }
    }
}
