using Verse;
namespace SR.NDQ.Mod
{
    public class NDQModSetting:ModSettings
    {
        public bool isOpenLog;
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref isOpenLog, "isOpenLog", false);
        }
        public void InitData() {
            isOpenLog = false;
        }
    }
}
