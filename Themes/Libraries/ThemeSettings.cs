namespace Frontend.Themes.Libraries
{
    public class ThemeSettings
    {
        public static void initialize(IConfiguration configuration)
        {
            config = configuration.GetSection("Theme").Get<ThemeBase>();
        }

        public static ThemeBase? Config { get { return config; } }

        private static ThemeBase? config;
    }
}
