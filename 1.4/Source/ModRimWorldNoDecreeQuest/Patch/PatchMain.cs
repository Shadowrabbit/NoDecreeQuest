// ******************************************************************
//       /\ /|       @file       PatchMain.cs
//       \ V/        @brief      
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-08 13:21:20
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************
using System.Reflection;
using HarmonyLib;
using JetBrains.Annotations;
using Verse;

namespace RabitSquare.NoDecreeQuest
{
	[UsedImplicitly]
	[StaticConstructorOnStartup]
	public class PatchMain
	{
		static PatchMain()
		{
			var instance = new Harmony("RabiSquare.NoDecreeQuest");
			instance.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
