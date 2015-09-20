using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace EO4SaveEdit.Controls
{
    public class SimpleProgressBar : UserControl
    {
        const int minDefault = 0, maxDefault = 100, valDefault = 0;

        int minimum, maximum, val;

        protected override Size DefaultSize
        {
            get { return new Size(120, 20); }
        }

        Rectangle barRectangle
        {
            get
            {
                double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));
                return new Rectangle(0, 0, (int)(this.Width * scaleFactor), this.Height);
            }
        }

        [System.ComponentModel.DefaultValue(minDefault)]
        public int Minimum
        {
            get { return minimum; }
            set
            {
                if (value < 0) minimum = 0;
                if (value > maximum) minimum = value;
                if (val < minimum) val = minimum;

                this.Invalidate();
            }
        }

        [System.ComponentModel.DefaultValue(maxDefault)]
        public int Maximum
        {
            get { return maximum; }
            set
            {
                if (value < minimum) minimum = value;
                maximum = value;
                if (val > maximum) val = maximum;

                this.Invalidate();
            }
        }

        [System.ComponentModel.DefaultValue(valDefault)]
        public int Value
        {
            get { return val; }
            set
            {
                if (value < minimum) val = minimum;
                else if (value > maximum) val = maximum;
                else val = value;

                this.Invalidate();
            }
        }

        VisualStyleRenderer barRenderer;

        public SimpleProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            minimum = minDefault;
            maximum = maxDefault;
            val = valDefault;

            barRenderer = new VisualStyleRenderer("PROGRESS", 5, 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!ProgressBarRenderer.IsSupported) throw new Exception("ProgressBarRenderer not supported");

            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            if (barRectangle.Width <= 0 || barRectangle.Height <= 0) return;
            barRenderer.DrawBackground(e.Graphics, barRectangle);
        }
    }
}
