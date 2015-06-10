using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EO4SaveEdit
{
    public class ListBoxEx : ListBox
    {
        public ListBoxEx()
        {
            DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1 && e.Index < Items.Count)
            {
                Color color = (isSelected ? SystemColors.Highlight : e.Index % 2 != 0 ? Color.WhiteSmoke : Color.White);
                using (SolidBrush backgroundBrush = new SolidBrush(color)) e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), e.Font, e.Bounds.Location, e.ForeColor, TextFormatFlags.Left);
            }
            e.DrawFocusRectangle();
        }
    }
}
