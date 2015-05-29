using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EO4SaveEdit
{
    class PanelEx : Panel
    {
        public PanelEx()
            : base()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
    }
}
