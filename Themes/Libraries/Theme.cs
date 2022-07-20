namespace Frontend.Themes.Libraries
{
    public class Theme : ITheme
    {
        public string ExtendCssFilename(string name)
        {
            return IsRtlDirection ? name.Replace(".css", ".rtl.css") : name;
        }

        /// <summary>
        /// Gets the assets path for given resource.
        /// </summary>
        /// <param name="name">Resource name.</param>
        /// <returns>A string value.</returns>
        public string GetAssetPath(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return name;
            }

            return $"{ThemeSettings.Config?.AssetsPath}/{name}";
        }

        /// <summary>
        /// Gets the favicon file for current theme.
        /// </summary>
        /// <returns>A string value.</returns>
        public string GetFavicon()
        {
            return GetAssetPath(ThemeSettings.Config?.Assets?.Favicon ?? "favicon.ico");
        }

        /// <summary>
        /// Gets the list of fonts to be applied to current theme.
        /// </summary>
        /// <returns>An array containing the font list if exists, otherwise an empty array.</returns>
        public string[] GetFonts()
        {
            var fonts = ThemeSettings.Config?.Assets?.Fonts;
            if (fonts == null)
            {
                return Array.Empty<string>();
            }

            return fonts.ToArray();
        }

        /// <summary>
        /// Gets the list of global assets.
        /// </summary>
        /// <returns>An array containing the asset list, if exists; otherwise an empty array.</returns>
        public string[] GetGlobalAssets(string scope)
        {
            var files = new List<string>();
            var assets = scope == "css"
                ? ThemeSettings.Config?.Assets?.Stylesheets
                : ThemeSettings.Config?.Assets?.Scripts;
            if (assets != null)
            {
                foreach (string file in assets)
                {
                    if (scope == "css")
                    {
                        files.Add(GetAssetPath(ExtendCssFilename(file)));
                    }
                }
            }

            return files.ToArray();
        }

        /// <summary>
        /// Gets theme mode.
        /// </summary>
        /// <returns>A string value.</returns>
        public string GetMode() => _mode;

        /// <summary>
        /// Gets vendor assets for given scope name.
        /// </summary>
        /// <param name="scope">Scope name.</param>
        /// <returns>An array of string with vendor assets if exists; otherwise an empty array.</returns>
        public string[] GetVendors(string scope)
        {
            var vendors = ThemeSettings.Config?.Vendors;
            var files = new List<string>();
            if (vendors != null)
            {
                foreach (var vendor in _vendorFiles)
                {
                    if (vendors.ContainsKey(vendor) && vendors[vendor].ContainsKey(scope))
                    {
                        var vendorFiles = vendors[vendor][scope];
                        foreach (var vendorFile in vendorFiles)
                        {
                            var vendorPath = vendorFile.Contains("https://")
                                ? vendorFile
                                : GetAssetPath(vendorFile);
                            files.Add(vendorPath);
                        }
                    }
                }
            }

            return files.ToArray();
        }

        /// <summary>
        /// Gets the path of a themed view by its name.
        /// </summary>
        /// <returns>A string value containing the path of the view.</returns>
        public string GetView(string name)
        {
            return $"{ThemeSettings.Config?.ViewsPath}/{name}";
        }

        /// <summary>
        /// Sets HTML attributes with given scope for the HTML template.
        /// </summary>
        /// <param name="scope">Scope name</param>
        /// <returns>A string value containing the attributes if exists, otherwise an empty string.</returns>
        public string? SetHtmlAttributes(string scope)
        {
            var list = new List<string>();
            if (_htmlAttributes.ContainsKey(scope))
            {
                foreach (KeyValuePair<string, string> attribute in _htmlAttributes[scope])
                {
                    var item = attribute.Key + "=" + attribute.Value;
                    list.Add(item);
                }

                return String.Join(" ", list);
            }

            return null;
        }

        /// <summary>
        /// Whether text direction is RTL.
        /// </summary>
        /// <returns><c>true</c> if text direction is RTL; otherwise <c>false</c>.</returns>
        public bool IsRtlDirection
        {
            get { return _textDirection.ToLower() == "rtl"; }
        }

        private readonly SortedDictionary<string, SortedDictionary<string, string>> _htmlAttributes = new SortedDictionary<string, SortedDictionary<string, string>>();
        private readonly string _mode = "system";
        private readonly string _textDirection = "ltr";
        private readonly List<string> _vendorFiles = new();
    }
}
