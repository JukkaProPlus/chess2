using System;

namespace ET
{
    public static class LanguageHelper
    {
        // public static string GetLanguageString(int id)
        // {
        //     switch (ConstValue.LanguageType)
        //     {
        //         case LanguageEnum.ZH_CN:
        //             return LanguageZHCNConfigCategory.Instance.Get(id).Str;
        //         case LanguageEnum.EN_US:
        //             return LanguageENUSConfigCategory.Instance.Get(id).Str;
        //         default:
        //             throw new Exception("LanguageType is not exist!");
        //     }
        // }
        public static string GetLanguageString(int id, params object[] args)
        {
            switch (ConstValue.LanguageType)
            {
                case LanguageEnum.ZH_CN:
                    Log.Info($"zh_cn{id.ToString()}");
                    return string.Format(LanguageZHCNConfigCategory.Instance.Get(id).Str, args);
                case LanguageEnum.EN_US:
                    Log.Info($"en_us{id.ToString()}");
                    return string.Format(LanguageENUSConfigCategory.Instance.Get(id).Str, args);
                default:
                    throw new Exception("LanguageType is not exist!");
            }
        }
        public static string GetLanguageAddCNString(int id, params object[] args)
        {
            string ansTail = $"${string.Format(LanguageZHCNConfigCategory.Instance.Get(id).Str, args)}$";
            string ans = null;
            switch (ConstValue.LanguageType)
            {
                case LanguageEnum.ZH_CN:
                    return string.Format(LanguageZHCNConfigCategory.Instance.Get(id).Str, args);
                case LanguageEnum.EN_US:
                    ans = string.Format(LanguageENUSConfigCategory.Instance.Get(id).Str, args);
                    break;
                default:
                    throw new Exception("LanguageType is not exist!");
            }
            return ans + ansTail;
        }
    }
}