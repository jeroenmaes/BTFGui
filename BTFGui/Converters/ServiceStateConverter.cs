using BizTalkFactory.Management.Automation;
using BTFGui.Enums;
using BTFGui.ObjectModel;

namespace BTFGui.Converters
{
    public static class ServiceStateConverter
    {
        public static ServiceState ToServiceState(this BtsServiceState value)
        {
            switch (value)
            {
                case BtsServiceState.Running:
                    return ServiceState.Running;
                case BtsServiceState.Stopped:
                    return ServiceState.Stopped;
                case BtsServiceState.NotApplicable:
                    return ServiceState.NotApplicable;
                case BtsServiceState.StartPending:
                    return ServiceState.StartPending;
                case BtsServiceState.StopPending:
                    return ServiceState.StopPending;
                case BtsServiceState.ContinuePending:
                    return ServiceState.ContinuePending;
                case BtsServiceState.PausePending:
                    return ServiceState.PausePending;
                case BtsServiceState.Paused:
                    return ServiceState.Paused;
                default:
                    return ServiceState.Unknown;

            }
        }
    }
}
