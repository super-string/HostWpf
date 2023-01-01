using System.ComponentModel;
using System.Windows;
using System.Windows.Forms.Integration;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfUIElementWrapperBase : System.Windows.Forms.Control
    {
        private UIElement _element;
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

        protected void RegisterUIElement(UIElement element)
        {
            _element = element;
            Host.Child = _element;
        }

        protected WpfUIElementWrapperBase()
        {
            Host = new ElementHost();
            Host.Location = new System.Drawing.Point(0, 0);
            Host.Dock = DockStyle.Fill;

            SuspendLayout();
            Controls.Add(Host);

            InitializeHost();
            ResumeLayout();
        }
        protected abstract void InitializeHost();
    }
}