using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml.Linq;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfContentControlWrapperBase : WpfControlWrapperBase
    {
        private ContentControl _element;

        [Category("WPF.UI")]
        public string ContentText
        {
            get
            {
                var tb = _element.Content as TextBlock;
                return tb?.Text;
            }
            set
            {
                var tb = new TextBlock();
                if (TextWrapping)
                {
                    tb.TextWrapping = System.Windows.TextWrapping.Wrap;
                }
                tb.Text = value;
                _element.Content = tb;
            }
        }

        [Category("WPF.UI")]
        public bool TextWrapping
        {
            get
            {
                var tb = _element.Content as TextBlock;
                return tb != null && tb.TextWrapping == System.Windows.TextWrapping.Wrap;
            }
            set
            {
                var tb = _element.Content as TextBlock;
                tb ??= new TextBlock();

                tb.TextWrapping = value ? System.Windows.TextWrapping.Wrap : System.Windows.TextWrapping.NoWrap;
            }
        }

        protected void RegisterContentControl(ContentControl element)
        {
            _element = element;
            RegisterControl(element);
        }
    }
}