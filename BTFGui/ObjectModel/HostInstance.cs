using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizTalkFactory.Management.Automation;
using System.Drawing;
using BTFGui.Enums;

namespace BTFGui.ObjectModel
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
                    return StatusIcon = new Icon("Resources/Stopped.ico");
                }

                return StatusIcon = new Icon("Resources/Running.ico");
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

   

    
}
