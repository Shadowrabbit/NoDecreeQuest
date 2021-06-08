// ******************************************************************
//       /\ /|       @file       UIWindowMain.cs
//       \ V/        @brief      主窗口
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-08 13:08:54
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************
using JetBrains.Annotations;
using UnityEngine;
using Verse;

namespace SR.ModRimWorld.NoDecreeQuest
{
	[StaticConstructorOnStartup]
	[UsedImplicitly]
	public class UIWindowMain : Mod
	{
		public static UIWindowMain instance;
		public readonly UIModelMain modSetting;
		private Vector2 _scrollPos;
		public UIWindowMain(ModContentPack content) : base(content)
		{
			modSetting = GetSettings<UIModelMain>();
			instance = this;
			_scrollPos = Vector2.zero;
		}

		public override string SettingsCategory()
		{
			return "TitleNoDecreeQuest".Translate();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			var viewRect = new Rect(0, 0, 0.9f * inRect.width, 0.8f * inRect.height);
			var ls = new Listing_Standard();
			ls.BeginScrollView(inRect, ref _scrollPos, ref viewRect);
			ls.CheckboxLabeled("ButtonIsOpenMod".Translate(), ref modSetting.isOpenMod, "Open Mod");
			ls.EndScrollView(ref viewRect);
		}
	}
}
