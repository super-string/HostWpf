using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfContentControlWrapperBase : System.Windows.Forms.Control
    {
        private ContentControl _element;
        internal ContentControl Core => _element;
        protected ElementHost Host { get; }

        private EffectType _effect = EffectType.None;
        [Category("WPF.UI")]
        public EffectType Effect
        {
            get => _effect;
            set
            {
                _effect = value;
                UIElementOperator.Effect(_effect, _element);
            }
        }

        private TransformInfo _transformInfo;
        [Category("WPF.UI")]
        public TransformInfo RotateTransform
        {
            get => _transformInfo;
            set
            {
                _transformInfo = value ?? new TransformInfo();
                UIElementOperator.Transform(_transformInfo, _element);
            }
        }

        [Category("WPF.UI")]
        public string ContentText
        {
            get => _element.Content as string; set => _element.Content = value;
        }

        [Category("WPF.UI")]
        public System.Drawing.Size ElementSize
        {
            get => new System.Drawing.Size((int)_element.Width, (int)_element.Height);
        }

        [Category("WPF.UI")]
        public Padding ElementPadding
        {
            get => new Padding((int)_element.Padding.Left, (int)_element.Padding.Top, (int)_element.Padding.Right, (int)_element.Padding.Bottom);
        }

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

        [Category("WPF.Host")]
        public System.Drawing.Size HostSize
        {
            get => new System.Drawing.Size(Host.Width, Host.Height);
            set
            {
                Host.Width = value.Width;
                Host.Height = value.Height;
            }
        }

        [Category("WPF.Host")]
        public DockStyle HostDock
        {
            get => Host.Dock;
            set => Host.Dock = value;
        }

        protected WpfContentControlWrapperBase()
        {
            Host = new ElementHost();
            InitializeHost();
        }

        protected abstract void InitializeHost();

        protected void AddToHost(ContentControl element)
        {
            _element = element;
            _element.Background = new LinearGradientBrush(
                            System.Windows.Media.Color.FromArgb(0xFF, 0x37, 0x6B, 0xBE),
                            System.Windows.Media.Color.FromArgb(0xFF, 0xD5, 0xF2, 0xB8),
                            new System.Windows.Point(0.5, 0),
                            new System.Windows.Point(0.5, 1)
                            );
            Host.Location = new System.Drawing.Point(0, 0);
            Host.Dock = DockStyle.Fill;
            Host.Child = _element;

            Controls.Add(Host);
        }
    }
    [Serializable]
    public abstract class WpfItemsControlWrapperBase : System.Windows.Forms.Control
    {
        private ItemsControl _element;
        internal ItemsControl Core => _element;

        protected ElementHost Host { get; }

        private EffectType _effect = EffectType.None;
        [Category("WPF.UI")]
        public EffectType Effect
        {
            get => _effect;
            set
            {
                _effect = value;
                UIElementOperator.Effect(_effect, _element);
            }
        }

        private TransformInfo _transformInfo;
        [Category("WPF.UI")]
        public TransformInfo RotateTransform
        {
            get => _transformInfo;
            set
            {
                _transformInfo = value ?? new TransformInfo();
                UIElementOperator.Transform(_transformInfo, _element);
            }
        }

        [Category("WPF.UI")]
        public System.Drawing.Size ElementSize
        {
            get => new System.Drawing.Size((int)_element.Width, (int)_element.Height);
        }

        [Category("WPF.UI")]
        public Padding ElementPadding
        {
            get => new Padding((int)_element.Padding.Left, (int)_element.Padding.Top, (int)_element.Padding.Right, (int)_element.Padding.Bottom);
        }

        [Category("WPF.UI")]
        public System.Windows.Forms.HorizontalAlignment HorizontalAlignment
        {
            get => (System.Windows.Forms.HorizontalAlignment)_element.HorizontalAlignment;
            set => _element.HorizontalAlignment = (System.Windows.HorizontalAlignment)value;
        }

        [Category("WPF.Host")]
        public System.Drawing.Size HostSize
        {
            get => new System.Drawing.Size(Host.Width, Host.Height);
            set
            {
                Host.Width = value.Width;
                Host.Height = value.Height;
            }
        }

        [Category("WPF.Host")]
        public DockStyle HostDock
        {
            get => Host.Dock;
            set => Host.Dock = value;
        }

        protected WpfItemsControlWrapperBase()
        {
            Host = new ElementHost();
            InitializeHost();
        }

        protected abstract void InitializeHost();

        protected void AddToHost(ItemsControl element)
        {
            _element = element;
            _element.Background = new LinearGradientBrush(
                            System.Windows.Media.Color.FromArgb(0xFF, 0x37, 0x6B, 0xBE),
                            System.Windows.Media.Color.FromArgb(0xFF, 0xD5, 0xF2, 0xB8),
                            new System.Windows.Point(0.5, 0),
                            new System.Windows.Point(0.5, 1)
                            );
            Host.Location = new System.Drawing.Point(0, 0);
            Host.Dock = DockStyle.Fill;
            Host.Child = _element;

            Controls.Add(Host);
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
            AddToHost(_label);
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
            AddToHost(_comboBox);
            ResumeLayout(true);
        }
    }
}