using BetterLyrics.Sdk.Abstractions.Plugins;
using System.ComponentModel.DataAnnotations;

namespace BetterLyrics.Plugins.Template
{
    public class Config : PluginConfigBase
    {
        [Display(Name = "Example Setting Name", Description = "Example Setting Description")]
        public string ExampleSetting
        {
            get => Get("Example Value");
            set => Set(value);
        }
    }
}
