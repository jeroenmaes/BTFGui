using System.Collections.Generic;
using System.Drawing;

namespace BTF.GUI.BO
{
    public class BApplication
    {
        public bool Selected { get; set; }

        private Icon _statusIcon;
        public Icon StatusIcon 
        {
            get
            {
                if (this.Status == BApplicationStatus.Stopped || this.Status == BApplicationStatus.NotApplicable)
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
        public BApplicationStatus Status { get; set; }
        public bool References { get; set; }
        public bool BackReferences { get; set; }
        public List<string> Resources { get; set; }
    }

    public enum BApplicationStatus
    {
        NotApplicable,
        Stopped,
        PartiallyStarted,
        Started,
    }
}
