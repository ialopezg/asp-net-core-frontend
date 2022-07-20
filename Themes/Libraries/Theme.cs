namespace Frontend.Themes.Libraries
{
    public class Theme : ITheme
    {
        /// <summary>
        /// Gets the default theme mode.
        /// </summary>
        /// <returns>A string value.</returns>
        public string GetMode() => _mode;

        /// <summary>
        /// Gets the path of a themed view by its name.
        /// </summary>
        /// <returns>A string value containing the path of the view.</returns>
        public string GetView(string name)
        {
            return $"{ThemeSettings.Config?.Path}/{name}";
        }

        private string _mode = "system";
    }
}
