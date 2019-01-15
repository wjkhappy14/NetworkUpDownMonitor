using System;
using System.Net.NetworkInformation;

namespace UpDownMonitor.IcmpPing
{
    public class PingResultEventArgs : EventArgs
    {
        public PingResultEventArgs(PingReply reply, Exception exception)
        {
            Reply = reply;

            Success = reply != null;
            LastException = exception;
        }

        public PingReply Reply { get; set; }

        public bool Success { get; set; }

        public Exception LastException { get; set; }

        public override string ToString()
        {
            string responseString = String.Empty;
            if (Success)
            {
                responseString = String.Format(
                    "Reply from {0}: bytes={1} time={2}ms TTL={3}", Reply.Address,
                    Reply.Buffer.Length, Reply.RoundtripTime, Reply.Options != null ? Reply.Options.Ttl : 0);
            }
            else
            {
                responseString = LastException.InnerException.Message;
            }
            return responseString;
        }
    }
}