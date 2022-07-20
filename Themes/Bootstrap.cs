using Frontend.Themes.Libraries;

namespace Frontend.Themes
{
    public class Bootstrap : IBootstrap
    {
        /// <summary>
        /// Initializes Theme Service with given theme.
        /// </summary>
        /// <param name="theme">Theme styles</param>
        public void Init(ITheme theme)
        {
            _theme = theme;

            InitThemeMode();
            InitThemeDirection();
            InitLayout();
            InitGlobalFiles();
        }

        public void InitGlobalFiles()
        { }

        public void InitLayout()
        { }

        public void InitThemeDirection()
        { }

        public void InitThemeMode()
        { }

        private ITheme? _theme;
    }
}
