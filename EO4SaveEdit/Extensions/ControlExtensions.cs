using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Linq.Expressions;

namespace EO4SaveEdit.Extensions
{
    public static class ControlExtensions
    {
        public static void SetBinding(this Control control, string propertyName, object dataSource, string dataMember)
        {
            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, dataSource, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
