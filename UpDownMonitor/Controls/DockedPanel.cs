using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UpDownMonitor.Controls {
    [Docking(DockingBehavior.Never)]
    public class DockedPanel : Panel {
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);

            Dock = DockStyle.Fill;
        }

        [Browsable(false)]
        [DefaultValue(DockStyle.Fill)]
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }
    }
}
