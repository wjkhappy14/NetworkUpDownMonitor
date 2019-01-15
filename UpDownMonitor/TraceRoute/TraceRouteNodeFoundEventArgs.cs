using System;

namespace UpDownMonitor.TraceRoute
{
    public class TraceRouteNodeFoundEventArgs : EventArgs
    {
        public TraceRouteNodeFoundEventArgs()
        {
        }

        public TraceRouteNodeFoundEventArgs(TraceRouteHopDetail detail)
            : this()
        {
            Detail = detail;
        }

        public TraceRouteHopDetail Detail { get; set; }
    }
}