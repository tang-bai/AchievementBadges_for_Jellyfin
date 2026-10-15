using System;
using System.Collections.Generic;
using Jellyfin.Plugin.AchievementBadges.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.AchievementBadges;

public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public static Plugin? Instance { get; private set; }

    /// <summary>
    /// Language code a fresh install starts in. Simplified Chinese, so the
    /// plugin's UI and badge text ship in Chinese out of the box. It is a
    /// starting point rather than a lock: a user's own pick in Preferences
    /// wins, and an admin can change the server-wide default on the config
    /// page. Keep this in step with the .js fallbacks (standalone.js,
    /// sidebar.js, enhance.js, index.html).
    /// </summary>
    public const string DefaultLanguageCode = "zh";

    /// <summary>
    /// Every UI language the plugin bundles a translation file for, i.e. the
    /// values accepted by <c>Configuration.DefaultLanguage</c> and by the
    /// per-user preference. Normalisation falls back to
    /// <see cref="DefaultLanguageCode"/> for anything outside this set.
    /// </summary>
    public static readonly IReadOnlySet<string> SupportedLanguages =
        new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "en", "fr", "es", "de", "it", "pt", "zh", "ja"
        };

    public override string Name => "Achievement Badges";

    public override Guid Id => Guid.Parse("d9f4b7d2-6c4d-4d7e-9d2d-1c6b4f8e2a11");

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "achievementbadges",
                EmbeddedResourcePath = "Jellyfin.Plugin.AchievementBadges.Pages.index.html",
                EnableInMainMenu = true,
                DisplayName = "Achievements",
                MenuSection = "user",
                MenuIcon = "emoji_events"
            },
            new PluginPageInfo
            {
                Name = "achievementbadgesconfigpage",
                EmbeddedResourcePath = "Jellyfin.Plugin.AchievementBadges.Configuration.configPage.html"
            }
        };
    }
}