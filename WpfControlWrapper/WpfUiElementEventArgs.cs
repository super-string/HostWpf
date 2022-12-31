namespace WpfControlWrapper
{
    public sealed class WpfUiElementEventArgs : EventArgs
    {
        public EventArgs Original { get; }
        public WpfUiElementEventArgs(EventArgs original)
        {
            Original = original;
        }
    }
}