using Microsoft.Extensions.DependencyInjection;

namespace WinBox;

public static class WebAssemblyHostBuilderExtensions
{
    public static IServiceCollection AddBlazorWinbox(this IServiceCollection services)
    {
        return services.AddScoped<IWindowManager, WinBoxWindowManager>();
    }
}
