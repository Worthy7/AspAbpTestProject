using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TestMPWAAspAbp.Localization
{
    public static class TestMPWAAspAbpLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TestMPWAAspAbpConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TestMPWAAspAbpLocalizationConfigurer).GetAssembly(),
                        "TestMPWAAspAbp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
