using System.Windows.Controls;

namespace WpfControlWrapper
{
    public class WpfComboBox : WpfItemsControlWrapperBase
    {
        private System.Windows.Controls.ComboBox _comboBox;
        public WpfComboBox() : base() { }

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
            _comboBox = new System.Windows.Controls.ComboBox();
            RegisterItemsControl(_comboBox);
        }
    }
}