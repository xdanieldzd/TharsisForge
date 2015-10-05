using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace EO4SaveEdit.FileHandlers
{
    // TODO: better name? more features...?
    public class DataChunk
    {
        protected Dictionary<string, object> originalValues = new Dictionary<string, object>();

        public virtual void ReadFromStream(Stream stream)
        {
            throw new NotImplementedException(string.Format("{0} not overridden in {1}", MethodBase.GetCurrentMethod(), this.GetType().FullName));
        }

        public virtual void WriteToStream(Stream stream)
        {
            throw new NotImplementedException(string.Format("{0} not overridden in {1}", MethodBase.GetCurrentMethod(), this.GetType().FullName));
        }

        protected void GetOriginalValues()
        {
            originalValues = new Dictionary<string, object>();
            foreach (PropertyInfo prop in this.GetType().GetProperties().Where(x => x.CanWrite)) originalValues.Add(prop.Name, prop.GetValue(this, null));
        }

        public bool HasPropertyChanged(string property)
        {
            object value = this.GetType().GetProperty(property).GetValue(this, null);
            return (!value.Equals(originalValues[property]));
        }
    }
}
