namespace ApexCharts.Blazor.Models
{
    public class ResponsiveOptions
    {
        public decimal Breakpoint { get; set; }
        public ChartConfiguration Options { get; set; }

        #region Method Chaining

        public ResponsiveOptions SetBreakpoint(decimal breakpoint)
        {
            Breakpoint = breakpoint;
            return this;
        }

        public ResponsiveOptions SetOptions(ChartConfiguration options)
        {
            Options = options;
            return this;
        }

        #endregion
    }
}
