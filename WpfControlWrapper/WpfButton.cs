using System.Windows.Media;

namespace WpfControlWrapper
{
    [Serializable]
    public class WpfButton : WpfContentControlWrapperBase
    {
        private System.Windows.Controls.Button _element = new System.Windows.Controls.Button();

        public WpfButton() : base() { }

        public event EventHandler<WpfUiElementEventArgs> Click = delegate { };

        protected override void InitializeHost()
        {
            RegisterContentControl(_element);
            _element.Click += _element_Click;
        }

        private void _element_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Click?.Invoke(sender, new WpfUiElementEventArgs(e));
        }
    }
}