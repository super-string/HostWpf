namespace HostWpf
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Integration.ElementHost _elementHost;
        public Form1()
        {
            InitializeComponent();

            InitElementHost();
        }

        private void InitElementHost()
        {
            _elementHost=new System.Windows.Forms.Integration.ElementHost();
            Controls.Add(_elementHost);
            SuspendLayout();
            _elementHost.Location = new System.Drawing.Point(0, 0); //location
            _elementHost.Name = "_elementHost1";
            _elementHost.Size = new System.Drawing.Size(800, 600);
            _elementHost.TabIndex = 0;
            _elementHost.Dock = DockStyle.Fill;
            _elementHost.Text = "";
            _elementHost.Child = new WpfCustomControlLibrary.UserControl1(); //wpf control
            ResumeLayout(false);
        }
    }
}