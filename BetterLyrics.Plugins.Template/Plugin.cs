using BetterLyrics.Sdk.Abstractions.Plugins;
using BetterLyrics.Sdk.Interfaces.Plugins;
using BetterLyrics.Sdk.Models.Lyrics;

namespace BetterLyrics.Plugins.Template
{
    public class Plugin : PluginBase<Config>, ILyricsSource
    {
        public override string Title { get; set; } = "TODO: Plugin Name";

        public Task<LyricsSearchResult> GetLyricsAsync(string title, string artist, string album, double duration, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        protected override async Task OnInitializeAsync()
        {
            // Do any initialization work here, such as setting up services, loading resources, etc.

            // Context.PluginDirectory; // This is the directory where your plugin is located. You can use it to load resources or configuration files.
            // Config.ExampleSetting = "Example Value"; // This is how you can access and modify your plugin's configuration settings.
        }

        protected override async Task OnShutdownAsync()
        {
            // Do any cleanup work here, such as disposing of resources, saving state, etc.
        }
    }
}
