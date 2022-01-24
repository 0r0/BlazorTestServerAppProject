using Microsoft.JSInterop;

namespace BlazorTestServerAppProject.Helpers
{
    public class RandomHelper
    {
        [JSInvokable]
        public static Task<int> GenerateRandomInt(int maxValue)
        {
            return Task.FromResult(new Random().Next(maxValue));
        }
    }
}
