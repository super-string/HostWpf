using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfControlWrapper
{
    [Serializable]
    public class WpfButton : WpfContentControlWrapperBase
    {
        private System.Windows.Controls.Button _element = new System.Windows.Controls.Button();

        public WpfButton() : base() { }

        public event EventHandler<WpfUiElementEventArgs> Click = delegate { };

        protected override void InitializeHost()
        {
            RegisterContentControl(_element);
            _element.Click += _element_Click;
        }

        private void _element_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Click?.Invoke(sender, new WpfUiElementEventArgs(e));
        }
        private Storyboard myStoryboard;
        public void Animation()
        {
            if (string.IsNullOrEmpty(_element.Name))
            {
                _element.Name = "animation";

                DoubleAnimation myDoubleAnimation = new DoubleAnimation();
                myDoubleAnimation.From = 1.0;
                myDoubleAnimation.To = 0.0;
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(500));
                myDoubleAnimation.AutoReverse = true;
                myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

                myStoryboard = new Storyboard();
                myStoryboard.Children.Add(myDoubleAnimation);
                Storyboard.SetTarget(myDoubleAnimation, _element);
                Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(TextBlock.OpacityProperty));

                myStoryboard.Begin();
            }
        }
    }
}