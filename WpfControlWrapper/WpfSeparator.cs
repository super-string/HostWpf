using System.Windows.Controls;

namespace WpfControlWrapper
{
    public sealed class WpfSeparator :WpfControlWrapperBase
    {
        private System.Windows.Controls.Separator _separator = new Separator();

        protected override void InitializeHost()
        {
            RegisterFraeworkControl(_separator);
        }
    }
}