using Microsoft.AspNetCore.Components;
namespace BlazorTestServerAppProject.Shared
{
    public class ChildComponentBase :ComponentBase
    {
        protected bool DarkThemeOn;
        protected string AlertTheme => DarkThemeOn ? "dark" : "light";
        [Parameter]
        public RenderFragment childContent { get; set; }

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }
    }
}
