namespace Frontend.Themes.Libraries
{
    /// <summary>
    /// Basic skeleton for <see cref="Theme"/> objects
    /// </summary>
    public interface ITheme
    {
        /// <summary>
        /// Resolves the correct filename for given CSS filename according the text direction.
        /// </summary>
        /// <param name="name">CSS filename.</param>
        /// <returns></returns>
        public string ExtendCssFilename(string name);

        /// <summary>
        /// Gets the asset path for given resource.
        /// </summary>
        /// <param name="name">Resource name.</param>
        /// <returns>A string value.</returns>
        public string GetAssetPath(string name);

        /// <summary>
        /// Get CSS files for current theme.
        /// </summary>
        /// <returns>An array containing CSS files; otherwise an empty array.</returns>
        public string[] GetCssFiles();

        /// <summary>
        /// Gets the favicon file for current theme.
        /// </summary>
        /// <returns>A string value.</returns>
        public string GetFavicon();

        /// <summary>
        /// Gets the list of fonts to be applied to current theme.
        /// </summary>
        /// <returns>An array containing the font list if exists, otherwise an empty array.</returns>
        public string[] GetFonts();
        
        /// <summary>
        /// Gets the list of global assets.
        /// </summary>
        /// <returns>An array containing the asset list, if exists; otherwise an empty array.</returns>
        public string[] GetGlobalAssets(string scope);

        /// <summary>
        /// Get script files for current theme.
        /// </summary>
        /// <returns>An array containing script files; otherwise an empty array.</returns>
        public string[] GetJavaScriptFiles();

        /// <summary>
        /// Gets the default theme mode.
        /// </summary>
        /// <returns>A string value.</returns>
        public string GetMode();

        /// <summary>
        /// Gets vendor assets for given scope name.
        /// </summary>
        /// <param name="scope">Scope name.</param>
        /// <returns>An array of string with vendor assets if exists, otherwise an empty array.</returns>
        public string[] GetVendors(string scope);

        /// <summary>
        /// Gets the path of a themed view by its name.
        /// </summary>
        /// <returns>A string value containing the path of the view</returns>
        public string GetView(string name);

        public string? SetHtmlAttributes(string scope);
    }
}
