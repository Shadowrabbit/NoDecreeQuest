// ******************************************************************
//       /\ /|       @file       DebugActionsRoyaltyExtension.cs
//       \ V/        @brief      扩展测试指令
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-08 14:09:48
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************
using System.Linq;
using JetBrains.Annotations;
using Verse;

namespace SR.ModRimWorld.NoDecreeQuest
{
    [UsedImplicitly]
    public static class DebugActionsRoyaltyExtension
    {
        /// <summary>
        /// 测试生成法令
        /// </summary>
        [UsedImplicitly]
        [DebugAction("SR.ModRimWorld.NoDecreeQuest", "Issue decree", allowedGameStates = AllowedGameStates.PlayingOnMap)]
        private static void IssueDecree()
        {
            var debugMenuOptionList = Find.FactionManager.AllFactions
                .Where(f => f.def.RoyalTitlesAwardableInSeniorityOrderForReading.Count > 0).Select(localFaction =>
                    new DebugMenuOption(localFaction.Name, DebugMenuOptionMode.Tool,
                        () => UI.MouseCell().GetFirstPawn(Find.CurrentMap)?.royalty.IssueDecree(true, "test reason"))).ToList();
            Find.WindowStack.Add(new Dialog_DebugOptionListLister(debugMenuOptionList));
        }
    }
}
