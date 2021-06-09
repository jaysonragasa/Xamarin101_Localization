using XamarinForms101_Localization.Strings;

namespace XamarinForms101_Localization.Helper
{
    public class LocalizeHelper
    {
        public static string Localize(string key)
        {
            string ret = string.Empty;

            ret = AppStringResources.ResourceManager.GetString(key);

            return ret;
        }
    }
}
