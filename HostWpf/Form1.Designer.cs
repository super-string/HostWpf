namespace HostWpf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wpfToggleButtonWrapper21 = new WpfControlWrapper.WpfToggleButtonWrapper();
            this.button1 = new System.Windows.Forms.Button();
            this.wpfButtonWrapper3 = new WpfControlWrapper.WpfButtonWrapper();
            this.wpfButtonWrapper1 = new WpfControlWrapper.WpfButtonWrapper();
            this.wpfComboBoxWrapper1 = new WpfControlWrapper.WpfComboBoxWrapper();
            this.SuspendLayout();
            // 
            // wpfToggleButtonWrapper21
            // 
            this.wpfToggleButtonWrapper21.Checked = false;
            this.wpfToggleButtonWrapper21.ContentText = null;
            this.wpfToggleButtonWrapper21.Effect = WpfControlWrapper.EffectType.DropShadowEffect;
            this.wpfToggleButtonWrapper21.HostDock = System.Windows.Forms.DockStyle.None;
            this.wpfToggleButtonWrapper21.HostSize = new System.Drawing.Size(200, 100);
            this.wpfToggleButtonWrapper21.Location = new System.Drawing.Point(91, 216);
            this.wpfToggleButtonWrapper21.Name = "wpfToggleButtonWrapper21";
            this.wpfToggleButtonWrapper21.RotateTransform = ((WpfControlWrapper.TransformInfo)(resources.GetObject("wpfToggleButtonWrapper21.RotateTransform")));
            this.wpfToggleButtonWrapper21.Size = new System.Drawing.Size(212, 96);
            this.wpfToggleButtonWrapper21.TabIndex = 0;
            this.wpfToggleButtonWrapper21.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            this.wpfToggleButtonWrapper21.CheckedChanged += new System.EventHandler<WpfControlWrapper.WpfUiElementEventArgs>(this.wpfToggleButtonWrapper21_Checked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wpfButtonWrapper3
            // 
            this.wpfButtonWrapper3.ContentText = "rotate";
            this.wpfButtonWrapper3.Effect = WpfControlWrapper.EffectType.None;
            this.wpfButtonWrapper3.HostDock = System.Windows.Forms.DockStyle.Fill;
            this.wpfButtonWrapper3.HostSize = new System.Drawing.Size(150, 181);
            this.wpfButtonWrapper3.Location = new System.Drawing.Point(12, 12);
            this.wpfButtonWrapper3.Name = "wpfButtonWrapper3";
            this.wpfButtonWrapper3.RotateTransform = ((WpfControlWrapper.TransformInfo)(resources.GetObject("wpfButtonWrapper3.RotateTransform")));
            this.wpfButtonWrapper3.Size = new System.Drawing.Size(150, 181);
            this.wpfButtonWrapper3.TabIndex = 5;
            this.wpfButtonWrapper3.Text = "wpfButtonWrapper3";
            this.wpfButtonWrapper3.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            // 
            // wpfButtonWrapper1
            // 
            this.wpfButtonWrapper1.ContentText = "aaaa";
            this.wpfButtonWrapper1.Effect = WpfControlWrapper.EffectType.None;
            this.wpfButtonWrapper1.HostDock = System.Windows.Forms.DockStyle.Fill;
            this.wpfButtonWrapper1.HostSize = new System.Drawing.Size(93, 171);
            this.wpfButtonWrapper1.Location = new System.Drawing.Point(280, 216);
            this.wpfButtonWrapper1.Name = "wpfButtonWrapper1";
            this.wpfButtonWrapper1.RotateTransform = ((WpfControlWrapper.TransformInfo)(resources.GetObject("wpfButtonWrapper1.RotateTransform")));
            this.wpfButtonWrapper1.Size = new System.Drawing.Size(93, 171);
            this.wpfButtonWrapper1.TabIndex = 6;
            this.wpfButtonWrapper1.Text = "wpfButtonWrapper1";
            this.wpfButtonWrapper1.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            this.wpfButtonWrapper1.Click += new System.EventHandler<WpfControlWrapper.WpfUiElementEventArgs>(this.wpfButtonWrapper1_Click);
            // 
            // wpfComboBoxWrapper1
            // 
            this.wpfComboBoxWrapper1.Effect = WpfControlWrapper.EffectType.DropShadowEffect;
            this.wpfComboBoxWrapper1.HostDock = System.Windows.Forms.DockStyle.Fill;
            this.wpfComboBoxWrapper1.HostSize = new System.Drawing.Size(255, 77);
            this.wpfComboBoxWrapper1.Location = new System.Drawing.Point(446, 51);
            this.wpfComboBoxWrapper1.Name = "wpfComboBoxWrapper1";
            this.wpfComboBoxWrapper1.RotateTransform = ((WpfControlWrapper.TransformInfo)(resources.GetObject("wpfComboBoxWrapper1.RotateTransform")));
            this.wpfComboBoxWrapper1.Size = new System.Drawing.Size(255, 77);
            this.wpfComboBoxWrapper1.TabIndex = 7;
            this.wpfComboBoxWrapper1.Text = "wpfComboBoxWrapper1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wpfComboBoxWrapper1);
            this.Controls.Add(this.wpfButtonWrapper1);
            this.Controls.Add(this.wpfButtonWrapper3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wpfToggleButtonWrapper21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private WpfControlWrapper.WpfToggleButtonWrapper wpfToggleButtonWrapper21;
        private Button button1;
        private WpfControlWrapper.WpfButtonWrapper wpfButtonWrapper3;
        private WpfControlWrapper.WpfButtonWrapper wpfButtonWrapper1;
        private WpfControlWrapper.WpfComboBoxWrapper wpfComboBoxWrapper1;
    }
}