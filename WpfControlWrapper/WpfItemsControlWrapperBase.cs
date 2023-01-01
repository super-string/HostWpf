using System.Windows.Controls;

namespace WpfControlWrapper
{
    [Serializable]
    public abstract class WpfItemsControlWrapperBase : WpfControlWrapperBase
    {
        private ItemsControl _element;

        protected void RegisterItemsControl(ItemsControl element)
        {
            _element = element;
            RegisterControl(element);
        }
    }
}