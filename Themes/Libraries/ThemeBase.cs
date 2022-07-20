namespace Frontend.Themes.Libraries
{
    /// <summary>
    /// Represents default theme style.
    /// </summary>
    class ThemeBase
    {

        /// <summary>
        /// Gets the assets list.
        /// </summary>
        public ThemeAssets? Assets { get; set; }

        /// <summary>
        /// Gets or sets theme path location.
        /// </summary>
        public string? AssetsPath { get; set; }

        /// <summary>
        /// Gets or sets default theme mode.
        /// </summary>
        public string? DefaultMode { get; set; }

        /// <summary>
        /// Whether theme mode can be switched.
        /// </summary>
        public bool EnabledSwitchMode { get; set; }

        /// <summary>
        /// Gets or sets text direction.
        /// </summary>
        public string? TextDirection { get; set; }

        /// <summary>
        /// Gets the list of vendor assets.
        /// </summary>
        public SortedDictionary<string, SortedDictionary<string, string[]>>? Vendors { get; set; }

        /// <summary>
        /// Gets or sets layout views locations.
        /// </summary>
        public string? ViewsPath { get; set; }
    }

    /// <summary>
    /// Represents an object that contains assets list for current theme.
    /// </summary>
    class ThemeAssets
    {
        /// <summary>
        /// Gets or sets the list of Stylesheet files to be applied to current theme.
        /// </summary>
        public List<string>? Stylesheets { get; set; }

        /// <summary>
        /// Gets or sets the favicon file to be applied to current theme.
        /// </summary>
        public string? Favicon { get; set; }

        /// <summary>
        /// Gets or sets the list of Fonts to be applied to current theme.
        /// </summary>
        public List<string>? Fonts { get; set; }

        /// <summary>
        /// Gets or sets the list of JavaScript files to be applied to current theme.
        /// </summary>
        public List<string>? Scripts { get; set; }
    }
}
