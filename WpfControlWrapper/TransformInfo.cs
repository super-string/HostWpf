using System.ComponentModel;
using System.Globalization;

namespace WpfControlWrapper
{
    [Serializable]
    [TypeConverter(typeof(TransformInfoConverter))]
    public sealed class TransformInfo
    {
        public double OriginX { get; set; }
        public double OriginY { get; set; }

        public double RotateTransformAngle { get; set; }

        public override string ToString()
        {
            return $"{OriginX}, {OriginY}, {RotateTransformAngle}";
        }
    }

    public sealed class TransformInfoConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string str)
            {
                var split = str.Split(",");
                if (split.Length != 3) return false;

                if (!double.TryParse(split[0], out var x)) return false;
                if (!double.TryParse(split[1], out var y)) return false;
                if (!double.TryParse(split[2], out var a)) return false;

                return new TransformInfo
                {
                    OriginX = x, 
                    OriginY = y,
                    RotateTransformAngle = a
                };
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(TransformInfo)) return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is TransformInfo ti)
            {
                return ti.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}