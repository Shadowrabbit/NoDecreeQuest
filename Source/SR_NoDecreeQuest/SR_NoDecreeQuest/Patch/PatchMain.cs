using Verse;
using HarmonyLib;
using System.Reflection;
namespace SR.NDQ.Patch
{
    [StaticConstructorOnStartup]
    public class PatchMain
    {
        public static Harmony instance;
        static PatchMain()
        {
            instance = new Harmony("SR.NoDecreeQuest");
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
