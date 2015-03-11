using BizTalkFactory.Management.Automation;
using BTFGui.Enums;
using BTFGui.ObjectModel;

namespace BTFGui.Converters
{
    public static class HostTypeConverter
    {        
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
    }
}
