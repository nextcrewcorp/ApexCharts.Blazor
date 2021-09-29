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
        public ChartConfiguration Configuration { get; set; }

        private string chartId = $"chart.{Guid.NewGuid()}";

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                await ChartService.CreateChart(chartId, GenerateOptions(), GenerateExtendedOptions());
            }
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
