using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCustomControlLibrary
{
    public class WpfToggleButton : ToggleButton
    {
        static WpfToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfToggleButton), new FrameworkPropertyMetadata(typeof(WpfToggleButton)));
        }
    }
}
