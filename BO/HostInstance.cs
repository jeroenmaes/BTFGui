using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizTalkFactory.Management.Automation;
using System.Drawing;

namespace BTF.GUI.BO
{
    public class HostInstance
    {
        public bool Selected { get; set; }
        
        private Icon _statusIcon;
        public Icon StatusIcon
        {
            get
            {
                if (this.Status == ServiceState.Stopped || this.Status == ServiceState.StopPending)
                {
                    return StatusIcon = new Icon("Icons/Stopped.ico");
                }

                return StatusIcon = new Icon("Icons/Running.ico");
            }
            private set
            {
                this._statusIcon = value;
            }
        }
        
        public string Name { get; set; }
        public HostType Type { get; set; }
        public string Server { get; set; }
        public ServiceState Status { get; set; }        
    }

    public enum ServiceState
    {
        NotApplicable,
        Stopped,
        StartPending,
        StopPending,
        Running,
        ContinuePending,
        PausePending,
        Paused,
        Unknown,
    }

    public enum HostType
    {
        Invalid,
        InProcess,
        Isolated,
    }
}
