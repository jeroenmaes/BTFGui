using BizTalkFactory.Management.Automation;

namespace BTF.GUI.BO
{
    public static class Extensions
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

        public static HostType ToHostType(this BtsHostType value)
        {
            switch (value)
            {
                case BtsHostType.InProcess:
                    return HostType.InProcess;
                case BtsHostType.Isolated:
                    return HostType.Isolated;
                default:
                    return HostType.Invalid;
            }
        }

        public static BApplicationStatus ToApplicationStatus(this BtsApplicationStatus value)
        {
            switch (value)
            {
                case BtsApplicationStatus.PartiallyStarted:
                    return BApplicationStatus.PartiallyStarted;
                case BtsApplicationStatus.Started:
                    return BApplicationStatus.Started;
                case BtsApplicationStatus.Stopped:
                    return BApplicationStatus.Stopped;
                default:
                    return BApplicationStatus.NotApplicable;
            }
        }
    }
}
