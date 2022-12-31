using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml.Linq;

namespace WpfControlWrapper
{
    internal static class UIElementOperator
    {
        public static void Effect(EffectType type, UIElement target)
        {
            switch (type)
            {
                case EffectType.None:
                    target.Effect = null;
                    break;
                case EffectType.BlurEffect:
                    target.Effect = new BlurEffect();
                    break;
                case EffectType.DropShadowEffect:
                    target.Effect = new DropShadowEffect();
                    break;
                default:
                    break;
            }
        }

        public static void Transform(TransformInfo info, UIElement target)
        {
            target.RenderTransformOrigin = new System.Windows.Point(info.OriginX, info.OriginY);
            var tg = new TransformGroup();
            if (info.RotateTransformAngle != 0)
            {
                tg.Children.Add(new RotateTransform(info.RotateTransformAngle));
            }
            target.RenderTransform = tg;
        }
    }
}