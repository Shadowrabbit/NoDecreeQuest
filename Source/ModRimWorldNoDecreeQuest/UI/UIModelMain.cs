// ******************************************************************
//       /\ /|       @file       UIModelMain.cs
//       \ V/        @brief      主窗口数据
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-08 13:11:46
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************
using Verse;

namespace SR.ModRimWorld.NoDecreeQuest
{
	public class UIModelMain : ModSettings
	{
		public bool isOpenMod;
		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look(ref isOpenMod, "ButtonIsOpenMod", true);
		}
	}
}
