using System.Text.Json.Serialization;

namespace ApexCharts.Blazor.Models
{
    public class Tools
    {
        /// <summary>
        /// Can be true|false or a string for a download icon:
        /// <img src="/static/icons/download.png" class="ico-download" width="20">
        /// toolbar/tools/download
        /// </summary>
        public object Download { get; set; }

        /// <summary>
        /// Enables selction rectangle.
        /// toolbar/tools/selection
        /// </summary>
        public object Selection { get; set; }

        /// <summary>
        /// Enables zoom.
        /// toolbar/tools/zoom
        /// </summary>
        public object Zoom { get; set; }

        /// <summary>
        /// Enables zoom in.
        /// toolbar/tools/zoomin
        /// </summary>
        [JsonPropertyName("zoomin")]
        public object ZoomIn { get; set; }

        /// <summary>
        /// Enables zoom out.
        /// toolbar/tools/zoomout
        /// </summary>
        [JsonPropertyName("zoomout")]
        public object ZoomOut { get; set; }

        /// <summary>
        /// Enables pan.
        /// toolbar/tools/pan
        /// </summary>
        public object Pan { get; set; }

        /// <summary>
        /// Enables reset.
        /// toolbar/tools/reset
        /// </summary>
        public object Reset { get; set; }

        #region Method Chaining

        public Tools SetDownload(object download)
        {
            Download = download;
            return this;
        }

        public Tools SetSelection(object selection)
        {
            Selection = selection;
            return this;
        }

        public Tools SetZoom(object zoom)
        {
            Zoom = zoom;
            return this;
        }

        public Tools SetZoomIn(object zoomIn)
        {
            ZoomIn = zoomIn;
            return this;
        }

        public Tools SetZoomOut(object zoomOut)
        {
            ZoomOut = zoomOut;
            return this;
        }

        public Tools SetPan(object pan)
        {
            Pan = pan;
            return this;
        }

        public Tools SetReset(object reset)
        {
            Reset = reset;
            return this;
        }

        #endregion

    }
}
