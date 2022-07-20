namespace Frontend.Themes.Libraries
{
    /// <summary>
    /// Basic skeleton for <see cref="Theme"/> objects
    /// </summary>
    public interface ITheme
    {
        public string GetMode();

        /// <summary>
        /// Gets the path of a themed view by its name.
        /// </summary>
        /// <returns>A string value containing the path of the view</returns>
        public string GetView(string name);
    }
}
