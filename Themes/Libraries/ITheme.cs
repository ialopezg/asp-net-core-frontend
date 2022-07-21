namespace Frontend.Themes.Libraries
{
    /// <summary>
    /// Basic skeleton for <see cref="Theme"/> objects
    /// </summary>
    public interface ITheme
    {
        /// <summary>
        /// Add HTML class for given directive name.
        /// </summary>
        /// <param name="scope">Scope name.</param>
        /// <param name="className">Class name.</param>
        void AddHtmlClass(string scope, string className);

        /// <summary>
        /// Resolves the correct filename for given CSS filename according the text direction.
        /// </summary>
        /// <param name="name">CSS filename.</param>
        /// <returns></returns>
        string ExtendCssFilename(string name);

        /// <summary>
        /// Gets the asset path for given resource.
        /// </summary>
        /// <param name="name">Resource name.</param>
        /// <returns>A string value.</returns>
        string GetAssetPath(string name);

        /// <summary>
        /// Get CSS files for current theme.
        /// </summary>
        /// <returns>An array containing CSS files; otherwise an empty array.</returns>
        string[] GetCssFiles();

        /// <summary>
        /// Gets the favicon file for current theme.
        /// </summary>
        /// <returns>A string value.</returns>
        string GetFavicon();

        /// <summary>
        /// Gets the list of fonts to be applied to current theme.
        /// </summary>
        /// <returns>An array containing the font list if exists, otherwise an empty array.</returns>
        string[] GetFonts();
        
        /// <summary>
        /// Gets the list of global assets.
        /// </summary>
        /// <returns>An array containing the asset list, if exists; otherwise an empty array.</returns>
        string[] GetGlobalAssets(string scope);

        /// <summary>
        /// Get script files for current theme.
        /// </summary>
        /// <returns>An array containing script files; otherwise an empty array.</returns>
        string[] GetJavaScriptFiles();

        /// <summary>
        /// Gets the default theme mode.
        /// </summary>
        /// <returns>A string value.</returns>
        string GetMode();

        /// <summary>
        /// Gets vendor assets for given scope name.
        /// </summary>
        /// <param name="scope">Scope name.</param>
        /// <returns>An array of string with vendor assets if exists, otherwise an empty array.</returns>
        string[] GetVendors(string scope);

        /// <summary>
        /// Gets the path of a themed view by its name.
        /// </summary>
        /// <returns>A string value containing the path of the view</returns>
        string GetView(string name);

        /// <summary>
        /// Sets HTML attributes with given scope for the HTML template.
        /// </summary>
        /// <param name="scope">Scope name</param>
        /// <returns>A string value containing the attributes, if exists; otherwise an empty string.</returns>
        string SetHtmlAttributes(string scope);

        /// <summary>
        /// Sets HTML classes for given scope.
        /// </summary>
        /// <param name="scope">Scope name.</param>
        /// <returns>A string value containing the scoped classes, if exists; otherwise an empty string.</returns>
        string SetHtmlClasses(string scope);

        /// <summary>
        /// Whether text direction is RTL.
        /// </summary>
        bool IsRtlDirection { get; }

        /// <summary>
        /// Gets or set text direction.
        /// </summary>
        TextDirection TextDirection { get; set; }
    }
}
