using WpfControlWrapper;

namespace HostWpf
{
    public partial class Form1 : Form
    {
        //System.Windows.Forms.Integration.ElementHost _elementHost;
        public Form1()
        {
            InitializeComponent();

            //InitElementHost();
        }

        //private void InitElementHost()
        //{
        //    _elementHost=new System.Windows.Forms.Integration.ElementHost();
        //    SuspendLayout();
        //    _elementHost.Location = new System.Drawing.Point(0, 0); //location
        //    _elementHost.Name = "_elementHost1";
        //    _elementHost.Size = new System.Drawing.Size(800, 600);
        //    _elementHost.TabIndex = 0;
        //    _elementHost.Dock = DockStyle.Fill;
        //    _elementHost.Text = "";
        //    _elementHost.Child = new WpfCustomControlLibrary.WpfToggleButton(); //wpf control
        //    Controls.Add(_elementHost);
        //    ResumeLayout(false);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void wpfToggleButtonWrapper21_Checked(object sender, WpfControlWrapper.WpfUiElementEventArgs e)
        {
            MessageBox.Show(wpfToggleButtonWrapper21.Checked.ToString());
        }

        private void wpfButtonWrapper3_Click(object sender, EventArgs e)
        {

        }

        private void wpfButtonWrapper3_Click_1(object sender, EventArgs e)
        {

        }

        private void wpfButtonWrapper1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wpfComboBoxWrapper1.AddButton("button", () => MessageBox.Show("Test"));
            wpfComboBoxWrapper1.AddSeparator();
            //wpfComboBoxWrapper1.AddItem(new WpfToggleButtonWrapper());

            wpfButtonWrapper1.Background = new System.Windows.Media.LinearGradientBrush(
                            System.Windows.Media.Color.FromArgb(0xFF, 0x37, 0x6B, 0xBE),
                            System.Windows.Media.Color.FromArgb(0xFF, 0xD5, 0xF2, 0xB8),
                            new System.Windows.Point(0.5, 0),
                            new System.Windows.Point(0.5, 1)
                            );

            wpfButtonWrapper3.Background = new System.Windows.Media.LinearGradientBrush(
                            System.Windows.Media.Color.FromArgb(0xFF, 0xff, 0x6B, 0x00),
                            System.Windows.Media.Color.FromArgb(0xFF, 0xa0, 0x70, 0xf3),
                            new System.Windows.Point(0.5, 0),
                            new System.Windows.Point(0.5, 1)
                            );

        }

        private void wpfButtonWrapper1_Click(object sender, WpfUiElementEventArgs e)
        {
            wpfButtonWrapper1.Effect = EffectType.DropShadowEffect;
        }

        private void wpfLabel1_Click(object sender, EventArgs e)
        {
        }

        private void wpfButtonWrapper3_Click(object sender, WpfUiElementEventArgs e)
        {
            wpfButtonWrapper3.Animation();
        }
    }
}