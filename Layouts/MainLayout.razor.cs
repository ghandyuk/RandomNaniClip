using System.Threading.Tasks;
using Blazorise;
using Microsoft.AspNetCore.Components;

namespace RandomNaniClip.Layouts
{
    public partial class MainLayout
    {
        [CascadingParameter] protected Theme Theme { get; set; }

        Task OnThemeChanged(bool isDarkMode)
        {
            if (Theme == null)
                return Task.CompletedTask;

            if (isDarkMode)
            {
                Theme.BackgroundOptions.Primary = Theme.BackgroundOptions.Dark;
                Theme.TextColorOptions.Primary = Theme.TextColorOptions.Dark;
                // Theme.TextColorOptions.Secondary = Theme.TextColorOptions.Light;
            }
            else
            {
                Theme.BackgroundOptions.Primary = Theme.BackgroundOptions.Light;
                Theme.TextColorOptions.Primary = Theme.TextColorOptions.Light;
                Theme.TextColorOptions.Secondary = Theme.TextColorOptions.Dark;
            }

            Theme.ThemeHasChanged();

            return Task.CompletedTask;
        }
    }

}