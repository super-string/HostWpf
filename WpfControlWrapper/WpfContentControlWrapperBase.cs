using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml.Linq;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfContentControlWrapperBase : WpfFrameworkElementWrapperBase
    {
        private ContentControl _element;
        internal ContentControl Core => _element;
        
        [Category("WPF.UI")]
        public string ContentText
        {
            get => _element.Content as string; set => _element.Content = value;
        }


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

        protected WpfContentControlWrapperBase()
        {
            InitializeHost();
        }

        protected abstract void InitializeHost();

        protected void RegisterContentControl(ContentControl element)
        {
            _element = element;
            RegisterFraeworkControl(element);
        }
    }
    [Serializable]
    public abstract class WpfItemsControlWrapperBase : WpfFrameworkElementWrapperBase
    {
        private ItemsControl _element;
        internal ItemsControl Core => _element;

        [Category("WPF.UI")]
        public Padding ElementPadding
        {
            get => new Padding((int)_element.Padding.Left, (int)_element.Padding.Top, (int)_element.Padding.Right, (int)_element.Padding.Bottom);
        }

        protected WpfItemsControlWrapperBase()
        {
            InitializeHost();
        }

        protected abstract void InitializeHost();

        protected void RegisterItemsControl(ItemsControl element)
        {
            _element = element;
            RegisterFraeworkControl(element);
        }
    }

    public sealed class WpfSeparator
    {
        //手抜き
        private System.Windows.Controls.Separator _separator = new Separator();
        internal System.Windows.Controls.Control Core => _separator;
    }

    public class WpfLabel : WpfContentControlWrapperBase
    {
        private System.Windows.Controls.Label _label = new System.Windows.Controls.Label();
        public WpfLabel() : base() { }

        protected override void InitializeHost()
        {
            SuspendLayout();
            RegisterContentControl(_label);
            ResumeLayout(true);
        }
    }
    public class WpfComboBoxWrapper : WpfItemsControlWrapperBase
    {
        private System.Windows.Controls.ComboBox _comboBox;
        public WpfComboBoxWrapper() : base() { }

        public void AddButton(string text, Action clickCallback)
        {
            var ctrl = new System.Windows.Controls.Button();
            ctrl.Width = _comboBox.Width;
            ctrl.Height = 20;
            ctrl.Content = text;
            ctrl.Click += (_, _) => clickCallback();
            _comboBox.Items.Add(ctrl);
        }
        public void AddItem(WpfContentControlWrapperBase ctrl)
        {
            _comboBox.Items.Add(ctrl.Core);
        }
        public void AddItem(WpfItemsControlWrapperBase ctrl) => _comboBox.Items.Add(ctrl.Core);
        public void AddSeparator() => _comboBox.Items.Add(new Separator());

        protected override void InitializeHost()
        {
            SuspendLayout();
            _comboBox = new System.Windows.Controls.ComboBox();
            RegisterItemsControl(_comboBox);
            ResumeLayout(true);
        }
    }
}