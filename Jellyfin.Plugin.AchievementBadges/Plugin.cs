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
        ApplyConfigurationMigrations();
    }

    /// <summary>
    /// Brings a configuration document written by an older release up to the
    /// current shape. Every release before 2.4.3 shipped English as the
    /// server-wide default, so an upgrade from one of those left the plugin
    /// English even though the shipped default is now Simplified Chinese:
    /// the stored value outranks the property initialiser. A document that
    /// predates the marker therefore has its DefaultLanguage re-seeded once.
    /// An admin who wants English back changes it on the config page, and
    /// that choice is then honoured because the marker stops the re-seed.
    /// Wrapped so a read-only or unwritable configuration directory can never
    /// stop the plugin from loading.
    /// </summary>
    private void ApplyConfigurationMigrations()
    {
        try
        {
            var configuration = Configuration;
            if (configuration is null || configuration.ConfigSchemaVersion >= 1)
            {
                return;
            }

            configuration.DefaultLanguage = DefaultLanguageCode;
            configuration.ConfigSchemaVersion = 1;
            SaveConfiguration();
        }
        catch
        {
            // Best effort only: an older document keeps its stored language
            // and the admin can still change it on the config page.
        }
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