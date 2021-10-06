using ApexCharts.Blazor.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApexCharts.Blazor
{
    public partial class Chart
    {
        [Inject]
        private ApexChartsService ChartService { get; set; }

        [Parameter]
        public List<BaseSeries> Series { get; set; } = new List<BaseSeries>();
        [Parameter]
        public ChartConfiguration Configuration { get; set; } = new ChartConfiguration();

        private string chartId = $"chart.{Guid.NewGuid()}";
        private bool hasBeenRendered = false;
        private string state;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                var options = GenerateOptions();
                var optionsJson = JsonSerializer.Serialize(options);
                await ChartService.CreateChart(chartId, options, GenerateExtendedOptions());
                hasBeenRendered = true;
                state = optionsJson;
            }
        }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.Name)
                {
                    case nameof(Series):
                        Series = (List<BaseSeries>)parameter.Value;
                        break;
                    case nameof(Configuration):
                        Configuration = (ChartConfiguration)parameter.Value;
                        break;
                    default: throw new Exception("There are no matching parameters found.");
                }
            }

            // Chart has changed so we need to update it.
            if (hasBeenRendered)
            {
                var options = GenerateOptions();
                var optionsJson = JsonSerializer.Serialize(options);

                if (state != optionsJson)
                {
                    await ChartService.UpdateChart(chartId, options, GenerateExtendedOptions());
                    state = optionsJson;
                }
            }

            await base.SetParametersAsync(ParameterView.Empty);
        }

        private object GenerateOptions()
        {
            Configuration.Series = Series;
            return Configuration;
        }

        private object GenerateExtendedOptions()
        {
            string yFormatExpression = null;

            if (Configuration.Tooltip != null)
            {
                yFormatExpression = Configuration.Tooltip.YFormatExpression;
            }

            string dataLabelsFormatExpression = null;

            if (Configuration.DataLabels != null)
            {
                if (Configuration.DataLabels.FormatExpression != null)
                {
                    dataLabelsFormatExpression = Configuration.DataLabels.FormatExpression;
                }
            }

            return new
            {
                yFormatExpression = yFormatExpression,
                dataLabelsFormatExpression = dataLabelsFormatExpression
            };
        }
    }
}
