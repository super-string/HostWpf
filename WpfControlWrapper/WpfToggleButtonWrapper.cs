using System.Windows;
using System.Windows.Forms.Design;
using System.Windows.Media;
using WpfCustomControlLibrary;

namespace WpfControlWrapper
{

    [Serializable]
    public class WpfToggleButtonWrapper : WpfContentControlWrapperBase
    {
        private WpfToggleButton _element;
        public event EventHandler<WpfUiElementEventArgs> CheckedChanged = delegate { };

        public bool Checked
        {
            get => _element.IsChecked.Value;
            set => _element.IsChecked = value;
        }

        private void _element_Checked(object sender, RoutedEventArgs e)
        {
            CheckedChanged?.Invoke(sender, new WpfUiElementEventArgs(e));
        }

        public WpfToggleButtonWrapper() : base() { }

        protected override void InitializeHost()
        {
            SuspendLayout();
            _element = new WpfToggleButton();
            _element.Checked += _element_Checked;
            _element.Unchecked += _element_Checked;
            RegisterContentControl(_element);
            ResumeLayout(true);
        }
    }
}