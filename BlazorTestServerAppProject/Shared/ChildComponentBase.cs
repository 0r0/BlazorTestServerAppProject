using BlazorTestServerAppProject.Services;
using Microsoft.AspNetCore.Components;
namespace BlazorTestServerAppProject.Shared
{
    public class ChildComponentBase :ComponentBase
    {
        protected bool DarkThemeOn;
        [Inject]
       protected RandomService RandomService { get; set; }   
        protected string AlertTheme => DarkThemeOn ? "dark" : "light";
        [Parameter]
        public RenderFragment childContent { get; set; }

        protected override void OnInitialized()
        {
            DarkThemeOn = true;
        }
    }
}
