using HarmonyLib;
using Verse;
using RimWorld;
using RimWorld.QuestGen;
using System;
using SR.NDQ.Mod;

namespace SR.NDQ.Patch
{
    public class QuestUtility_Patch
    {
        //[HarmonyPatch(typeof(QuestUtility))]
        //[HarmonyPatch("GenerateQuestAndMakeAvailable")]
        //[HarmonyPatch(new Type[] {typeof(QuestScriptDef),typeof(Slate)})]
        [HarmonyPatch(typeof(QuestUtility), "GenerateQuestAndMakeAvailable", new Type[] { typeof(QuestScriptDef), typeof(Slate) })]
        class QuestUtility_Patch1 {
            [HarmonyPrefix]
            static bool Prefix(ref Quest __result, QuestScriptDef root, Slate vars)
            {
                NDQMain.instance.SRLog("GenerateQuestAndMakeAvailable");
                if (!NDQMain.instance.modSetting.isOpenMod)
                {
                    return true;
                }
                bool isDecreeQuest = false;
                if (root.decreeTags != null)
                {
                    foreach (var s in root.decreeTags)
                    {
                        if (s.Equals("All"))
                        {
                            isDecreeQuest = true;
                        }
                    }
                }
                if (!isDecreeQuest)
                {
                    Quest quest = QuestGen.Generate(root, vars);
                    Find.QuestManager.Add(quest);
                    __result = quest;
                }
                else
                {
                    __result = null;
                    NDQMain.instance.SRLog("法令任务已拦截");
                }
                return false;//false将不执行原方法
            }
        }
        [HarmonyPatch(typeof(QuestUtility), "SendLetterQuestAvailable", new Type[] { typeof(Quest) })]
        class QuestUtility_Patch2
        {
            [HarmonyPrefix]
            static bool Prefix(Quest quest)
            {
                NDQMain.instance.SRLog("SendLetterQuestAvailable");
                if (!NDQMain.instance.modSetting.isOpenMod)
                {
                    return true;
                }
                return quest != null;
            }
        }
    }
}
