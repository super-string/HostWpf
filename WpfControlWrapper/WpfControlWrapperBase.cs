using System.ComponentModel;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfControlWrapperBase : WpfFrameworkElementWrapperBase
    {
        private System.Windows.Controls.Control _element;
        internal System.Windows.Controls.Control Core => _element;

        [Category("WPF.UI")]
        public Padding ElementPadding
        {
            get => new Padding((int)_element.Padding.Left, (int)_element.Padding.Top, (int)_element.Padding.Right, (int)_element.Padding.Bottom);
        }

        [Category("WPF.UI")]
        public System.Windows.Media.Brush Background
        {
            get => _element.Background;
            set => _element.Background = value;
        }

        protected void RegisterControl(System.Windows.Controls.Control element)
        {
            _element = element;
            RegisterFraeworkControl(_element);
        }
    }
}