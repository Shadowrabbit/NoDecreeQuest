using UnityEngine;
using Verse;

namespace SR.NDQ.Mod
{
    [StaticConstructorOnStartup]
    public class NDQMain : Verse.Mod
    {
        public static NDQMain instance;
        NDQModSetting modSetting;
        public Vector2 scrollPos;
        public NDQMain(ModContentPack content) : base(content)
        {
            modSetting = GetSettings<NDQModSetting>();
            instance = this;
            scrollPos = Vector2.zero;
        }
        public override string SettingsCategory()
        {
            return "NoDecreeQuest".Translate();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Rect viewRect = new Rect(0, 0, 0.9f * inRect.width, 0.8f * inRect.height);
            Listing_Standard ls = new Listing_Standard();
            ls.BeginScrollView(inRect,ref scrollPos,ref viewRect);
            if (ls.ButtonText("Default".Translate())) { modSetting.InitData(); }
            ls.CheckboxLabeled("OpenLog".Translate(), ref modSetting.isOpenLog, "This is just for developer to test");
            ls.EndScrollView(ref viewRect);
        }
        public void SRLog(string msg)
        {
            if (modSetting.isOpenLog)
            {
                Log.Warning(msg);
            }
        }
    }
}
