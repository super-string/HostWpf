using System.ComponentModel;
using System.Windows.Controls;

namespace WpfControlWrapper
{
    [Serializable]
    public class WpfStackPanel : WpfFrameworkElementWrapperBase
    {
        private StackPanel _stackPanel = new StackPanel();

        [Browsable(false)]
        public System.Windows.Media.Brush Background
        {
            get => _stackPanel.Background;
            set => _stackPanel.Background = value;
        }

        protected override void InitializeHost()
        {
            RegisterUIElement(_stackPanel);
        }
    }
}