using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace ApexCharts.Blazor
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class ApexChartsService : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ApexChartsService(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/ApexCharts.Blazor/apex-charts-blazor.js?10").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async ValueTask GetCharts()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("getCharts");
        }

        public async ValueTask CreateChart(string chartId, object options, object extendedOptions)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("createChart", chartId, options, extendedOptions);
        }

        public async ValueTask UpdateChart(string chartId, object options, object extendedOptions)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("updateChart", chartId, options, extendedOptions);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
