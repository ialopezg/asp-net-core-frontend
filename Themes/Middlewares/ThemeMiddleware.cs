using Frontend.Themes;
using Frontend.Themes.Libraries;

namespace Frontend.Middlewares
{
    public class ThemeMiddleware
    {
        public ThemeMiddleware(RequestDelegate next, ILogger<ThemeMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITheme theme, IBootstrap bootstrap)
        {
            bootstrap.Init(theme);

            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }

        private readonly ILogger<ThemeMiddleware> _logger;
        private readonly RequestDelegate _next;
    }

    public static class ThemeMiddlewareExtensions
    {
        public static IApplicationBuilder UseThemeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ThemeMiddleware>();
        }
    }
}
