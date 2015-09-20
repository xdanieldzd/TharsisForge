using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EO4SaveEdit.Controls
{
    public class ListBoxEx : ListBox
    {
        [System.ComponentModel.DefaultValue(false)]
        public bool AlternateBackColorOnDraw { get; set; }
        [System.ComponentModel.DefaultValue(typeof(Color), "ButtonFace")]
        public Color AltBackColor { get; set; }

        public ListBoxEx()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.AlternateBackColorOnDraw = false;
            this.AltBackColor = SystemColors.ButtonFace;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index > -1 && e.Index < Items.Count)
            {
                Color backColor = ((e.State & DrawItemState.Selected) == DrawItemState.Selected && this.Enabled ? SystemColors.Highlight : (AlternateBackColorOnDraw && e.Index % 2 != 0 ? AltBackColor : BackColor));
                using (SolidBrush backgroundBrush = new SolidBrush(backColor)) e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), e.Font, e.Bounds.Location, (this.Enabled ? e.ForeColor : SystemColors.ControlDark), TextFormatFlags.Left);
            }
            e.DrawFocusRectangle();
        }

        /* Based on http://yacsharpblog.blogspot.de/2008/07/listbox-flicker.html */
        protected override void OnPaint(PaintEventArgs e)
        {
            Region region = new Region(e.ClipRectangle);
            e.Graphics.FillRegion(new SolidBrush(BackColor), region);

            if (Items.Count > 0)
            {
                for (int i = 0; i < Items.Count; ++i)
                {
                    Rectangle rect = GetItemRectangle(i);

                    if (e.ClipRectangle.IntersectsWith(rect))
                    {
                        DrawItemState itemState = (((SelectionMode == SelectionMode.One && SelectedIndex == i) ||
                            (SelectionMode == SelectionMode.MultiSimple && SelectedIndices.Contains(i)) ||
                            (SelectionMode == SelectionMode.MultiExtended && SelectedIndices.Contains(i))) ? DrawItemState.Selected : DrawItemState.Default);

                        OnDrawItem(new DrawItemEventArgs(e.Graphics, Font, rect, i, itemState, ForeColor, BackColor));

                        region.Complement(rect);
                    }
                }
            }
            base.OnPaint(e);
        }
    }
}
