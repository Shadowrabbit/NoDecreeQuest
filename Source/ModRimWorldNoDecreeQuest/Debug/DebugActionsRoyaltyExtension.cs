﻿// ******************************************************************
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
		[DebugAction("General", "发布法令", allowedGameStates = AllowedGameStates.PlayingOnMap)]
		private static void Award4RoyalFavor()
		{
			var debugMenuOptionList = Find.FactionManager.AllFactions
				.Where(f => f.def.RoyalTitlesAwardableInSeniorityOrderForReading.Count > 0).Select(localFaction =>
					new DebugMenuOption(localFaction.Name, DebugMenuOptionMode.Tool,
						() => UI.MouseCell().GetFirstPawn(Find.CurrentMap)?.royalty.IssueDecree(true, "随随便便的理由"))).ToList();
			Find.WindowStack.Add(new Dialog_DebugOptionListLister(debugMenuOptionList));
		}
	}
}