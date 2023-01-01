using System.ComponentModel;
using System.Windows;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfFrameworkElementWrapperBase : WpfUIElementWrapperBase
    {
        private FrameworkElement _element;

        [Category("WPF.UI")]
        public System.Windows.HorizontalAlignment HorizontalAlignment
        {
            get => _element.HorizontalAlignment;
            set => _element.HorizontalAlignment = value;
        }

        [Category("WPF.UI")]
        public System.Windows.VerticalAlignment VerticalAlignment
        {
            get => _element.VerticalAlignment;
            set => _element.VerticalAlignment = value;
        }

        [Category("WPF.UI")]
        public double ElementWidth { get => _element.Width; set => _element.Width = value; }
        [Category("WPF.UI")]
        public double ElementHeight { get => _element.Height; set => _element.Height = value; }

        protected void RegisterFraeworkControl(FrameworkElement element)
        {
            _element = element;
            RegisterUIElement(element);
        }
    }
}