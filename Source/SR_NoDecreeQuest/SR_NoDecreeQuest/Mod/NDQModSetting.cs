using Verse;
namespace SR.NDQ.Mod
{
    public class NDQModSetting:ModSettings
    {
        public bool isOpenMod;
        public bool isOpenLog;
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref isOpenMod, "isOpenMod", true);
            Scribe_Values.Look(ref isOpenLog, "isOpenLog", false);
        }
        public void InitData() {
            isOpenMod = true;
            isOpenLog = false;
        }
    }
}
