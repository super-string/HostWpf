namespace WpfControlWrapper
{
    public class WpfLabel : WpfContentControlWrapperBase
    {
        private System.Windows.Controls.Label _label = new System.Windows.Controls.Label();
        public WpfLabel() : base() { }

        protected override void InitializeHost()
        {
            RegisterContentControl(_label);
        }
    }
}