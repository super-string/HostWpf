namespace WpfControlWrapper
{
    [Serializable]
    public class WpfButtonWrapper : WpfContentControlWrapperBase
    {
        private System.Windows.Controls.Button _element = new System.Windows.Controls.Button();

        public WpfButtonWrapper() : base() { }

        public event EventHandler<WpfUiElementEventArgs> Click = delegate { };

        protected override void InitializeHost()
        {
            SuspendLayout();
            RegisterContentControl(_element);
            _element.Click += _element_Click;
            ResumeLayout(true);
        }

        private void _element_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Click?.Invoke(sender, new WpfUiElementEventArgs(e));
        }
    }
}