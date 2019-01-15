using System;

namespace UpDownMonitor.IcmpPing
{
    public class PingManagerStateChangedEventArgs : EventArgs
    {
        public PingManagerStateChangedEventArgs(PingManagerStates newState) => NewState = newState;

        public PingManagerStates NewState { get; set; }
    }
}