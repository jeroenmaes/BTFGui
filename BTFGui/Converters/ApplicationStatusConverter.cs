using BizTalkFactory.Management.Automation;
using BTFGui.Enums;
using BTFGui.ObjectModel;

namespace BTFGui.Converters
{
    public static class ApplicationStatusConverter
    {       
        public static ApplicationStatus ToApplicationStatus(this BtsApplicationStatus value)
        {
            switch (value)
            {
                case BtsApplicationStatus.PartiallyStarted:
                    return ApplicationStatus.PartiallyStarted;
                case BtsApplicationStatus.Started:
                    return ApplicationStatus.Started;
                case BtsApplicationStatus.Stopped:
                    return ApplicationStatus.Stopped;
                default:
                    return ApplicationStatus.NotApplicable;
            }
        }
    }
}
