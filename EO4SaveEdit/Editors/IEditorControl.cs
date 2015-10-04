using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    interface IEditorControl
    {
        void Initialize(SaveDataHandler handler);
    }
}
