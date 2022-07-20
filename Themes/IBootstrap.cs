using Frontend.Themes.Libraries;

namespace Frontend.Themes
{
    public interface IBootstrap
    {
        void InitThemeMode();

        void InitThemeDirection();

        void InitLayout();

        void Init(ITheme theme);
    }
}
