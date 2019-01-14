using System;
using System.Linq;
using System.Windows.Forms;

namespace UpDownMonitor.Controls
{
    public partial class PanelStack : Control
    {
        private DockedPanel[] panels;

        private DockedPanel selectedPanel;

        public PanelStack()
        {
            InitializeComponent();
        }

        public DockedPanel[] Panels
        {
            get { return panels; }
            set
            {
                panels = value;

                foreach (DockedPanel panel in value)
                {
                    Controls.Add(panel);
                }
                SelectedPanel = value.FirstOrDefault();
            }
        }

        public DockedPanel SelectedPanel
        {
            get { return selectedPanel; }
            set
            {
                foreach (DockedPanel panel in Panels)
                {
                    panel.Visible = panel == value;
                }

                selectedPanel = value;
            }
        }
    }
}
