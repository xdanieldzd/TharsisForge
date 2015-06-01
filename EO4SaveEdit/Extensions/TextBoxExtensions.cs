using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace EO4SaveEdit.Extensions
{
    public enum CustomTextBoxDataType
    {
        NumberDecimal, NumberHexadecimal, String
    };

    public static class TextBoxExtensions
    {
        public static void CustomInit(this TextBox textBox, CustomTextBoxDataType dataType, object value, EventHandler textChangedEvent)
        {
            if (dataType == CustomTextBoxDataType.NumberHexadecimal && value.GetType().IsValueType)
                textBox.Text = string.Format("0x{0:X2}", value);
            else if (dataType == CustomTextBoxDataType.NumberDecimal && value.GetType().IsValueType)
                textBox.Text = string.Format("{0}", value);
            else if (dataType == CustomTextBoxDataType.String && value is string)
                textBox.Text = (string)value;

            textBox.TextChanged += textChangedEvent;
        }

        public static dynamic GetNumber(this TextBox textBox, Type propType, CustomTextBoxDataType dataType)
        {
            dynamic num = null;

            try
            {
                if (dataType == CustomTextBoxDataType.NumberDecimal || dataType == CustomTextBoxDataType.NumberHexadecimal)
                {
                    string str = (textBox.Text.ToLowerInvariant().StartsWith("0x") ? textBox.Text.Substring(2) : textBox.Text);
                    num = propType.GetMethod("Parse", new Type[]
                    {
                        typeof(string), typeof(NumberStyles), typeof(IFormatProvider)
                    }
                    ).Invoke(null, new object[]
                    {
                        str, (dataType == CustomTextBoxDataType.NumberHexadecimal ? NumberStyles.HexNumber : NumberStyles.Integer), CultureInfo.InvariantCulture
                    });
                }
                return num;
            }
            catch { }

            return num;
        }
    }
}
