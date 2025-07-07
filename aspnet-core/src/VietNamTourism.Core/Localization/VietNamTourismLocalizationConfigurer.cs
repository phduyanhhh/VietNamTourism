using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VietNamTourism.Localization;

public static class VietNamTourismLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(VietNamTourismConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(VietNamTourismLocalizationConfigurer).GetAssembly(),
                    "VietNamTourism.Localization.SourceFiles"
                )
            )
        );

    }
}
