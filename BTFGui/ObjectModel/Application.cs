using BTFGui.Enums;
using System.Collections.Generic;
using System.Drawing;

namespace BTFGui.ObjectModel
{
    public class BizTalkApplication
    {
        public bool Selected { get; set; }

        private Icon _statusIcon;
        public Icon StatusIcon 
        {
            get
            {
                if (this.Status == ApplicationStatus.Stopped || this.Status == ApplicationStatus.NotApplicable)
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
        public ApplicationStatus Status { get; set; }
        public bool References { get; set; }
        public bool BackReferences { get; set; }
        public List<string> Resources { get; set; }
    }    
}
