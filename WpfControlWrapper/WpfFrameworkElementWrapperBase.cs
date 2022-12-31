using System.ComponentModel;
using System.Windows;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfFrameworkElementWrapperBase : WpfUIElementWrapperBase
    {
        private FrameworkElement _element;

        [Category("WPF.UI")]
        public System.Windows.Forms.HorizontalAlignment HorizontalAlignment
        {
            get => (System.Windows.Forms.HorizontalAlignment)_element.HorizontalAlignment;
            set => _element.HorizontalAlignment = (System.Windows.HorizontalAlignment)value;
        }

        [Category("WPF.UI")]
        public System.Windows.VerticalAlignment VerticalAlignment
        {
            get => _element.VerticalAlignment;
            set => _element.VerticalAlignment = value;
        }

        [Category("WPF.UI")]
        public System.Drawing.Size ElementSize
        {
            get => new System.Drawing.Size((int)_element.Width, (int)_element.Height);
        }

        protected void RegisterFraeworkControl(FrameworkElement element)
        {
            _element = element;
            RegisterUIElement(element);
        }
    }
}