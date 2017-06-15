namespace LightController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rgbColorDialog = new System.Windows.Forms.ColorDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.normalTabPage = new System.Windows.Forms.TabPage();
            this.brightnessLabel = new MaterialSkin.Controls.MaterialLabel();
            this.offButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.onButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rgbTabPage = new System.Windows.Forms.TabPage();
            this.colorPickerButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.cinemaTabPage = new System.Windows.Forms.TabPage();
            this.cinemaModeLightChekcBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.cinemaModeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.settingTabPage = new System.Windows.Forms.TabPage();
            this.settingsThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsColorSchemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsSaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsIpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsIpTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.brightnessTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.settingsThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.settingsColorSchemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.tabControl.SuspendLayout();
            this.normalTabPage.SuspendLayout();
            this.rgbTabPage.SuspendLayout();
            this.cinemaTabPage.SuspendLayout();
            this.settingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbColorDialog
            // 
            this.rgbColorDialog.AnyColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Light";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(410, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.normalTabPage);
            this.tabControl.Controls.Add(this.rgbTabPage);
            this.tabControl.Controls.Add(this.cinemaTabPage);
            this.tabControl.Controls.Add(this.settingTabPage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 117);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(410, 200);
            this.tabControl.TabIndex = 1;
            // 
            // normalTabPage
            // 
            this.normalTabPage.Controls.Add(this.brightnessTrackBar);
            this.normalTabPage.Controls.Add(this.brightnessLabel);
            this.normalTabPage.Controls.Add(this.offButton);
            this.normalTabPage.Controls.Add(this.onButton);
            this.normalTabPage.Location = new System.Drawing.Point(4, 22);
            this.normalTabPage.Name = "normalTabPage";
            this.normalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.normalTabPage.Size = new System.Drawing.Size(402, 174);
            this.normalTabPage.TabIndex = 0;
            this.normalTabPage.Text = "Normal";
            this.normalTabPage.UseVisualStyleBackColor = true;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Depth = 0;
            this.brightnessLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.brightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brightnessLabel.Location = new System.Drawing.Point(164, 76);
            this.brightnessLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(80, 19);
            this.brightnessLabel.TabIndex = 5;
            this.brightnessLabel.Text = "Brightness";
            // 
            // offButton
            // 
            this.offButton.Depth = 0;
            this.offButton.Location = new System.Drawing.Point(233, 15);
            this.offButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.offButton.Name = "offButton";
            this.offButton.Primary = true;
            this.offButton.Size = new System.Drawing.Size(75, 23);
            this.offButton.TabIndex = 3;
            this.offButton.Text = "Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // onButton
            // 
            this.onButton.Depth = 0;
            this.onButton.Location = new System.Drawing.Point(99, 15);
            this.onButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.onButton.Name = "onButton";
            this.onButton.Primary = true;
            this.onButton.Size = new System.Drawing.Size(75, 23);
            this.onButton.TabIndex = 2;
            this.onButton.Text = "On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // rgbTabPage
            // 
            this.rgbTabPage.Controls.Add(this.colorPickerButton);
            this.rgbTabPage.Location = new System.Drawing.Point(4, 22);
            this.rgbTabPage.Name = "rgbTabPage";
            this.rgbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rgbTabPage.Size = new System.Drawing.Size(402, 174);
            this.rgbTabPage.TabIndex = 1;
            this.rgbTabPage.Text = "RGB";
            this.rgbTabPage.UseVisualStyleBackColor = true;
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.AutoSize = true;
            this.colorPickerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPickerButton.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton.Depth = 0;
            this.colorPickerButton.Location = new System.Drawing.Point(151, 44);
            this.colorPickerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.colorPickerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Primary = false;
            this.colorPickerButton.Size = new System.Drawing.Size(106, 36);
            this.colorPickerButton.TabIndex = 0;
            this.colorPickerButton.Text = "Color picker";
            this.colorPickerButton.UseVisualStyleBackColor = false;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            // 
            // cinemaTabPage
            // 
            this.cinemaTabPage.Controls.Add(this.cinemaModeLightChekcBox);
            this.cinemaTabPage.Controls.Add(this.cinemaModeCheckBox);
            this.cinemaTabPage.Location = new System.Drawing.Point(4, 22);
            this.cinemaTabPage.Name = "cinemaTabPage";
            this.cinemaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cinemaTabPage.Size = new System.Drawing.Size(402, 174);
            this.cinemaTabPage.TabIndex = 2;
            this.cinemaTabPage.Text = "Cinema";
            this.cinemaTabPage.UseVisualStyleBackColor = true;
            // 
            // cinemaModeLightChekcBox
            // 
            this.cinemaModeLightChekcBox.AutoSize = true;
            this.cinemaModeLightChekcBox.Depth = 0;
            this.cinemaModeLightChekcBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.cinemaModeLightChekcBox.Location = new System.Drawing.Point(164, 68);
            this.cinemaModeLightChekcBox.Margin = new System.Windows.Forms.Padding(0);
            this.cinemaModeLightChekcBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cinemaModeLightChekcBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.cinemaModeLightChekcBox.Name = "cinemaModeLightChekcBox";
            this.cinemaModeLightChekcBox.Ripple = true;
            this.cinemaModeLightChekcBox.Size = new System.Drawing.Size(61, 30);
            this.cinemaModeLightChekcBox.TabIndex = 2;
            this.cinemaModeLightChekcBox.Text = "Light";
            this.cinemaModeLightChekcBox.UseVisualStyleBackColor = true;
            this.cinemaModeLightChekcBox.CheckedChanged += new System.EventHandler(this.cinemaModeLightCheckbox_Changed);
            // 
            // cinemaModeCheckBox
            // 
            this.cinemaModeCheckBox.AutoSize = true;
            this.cinemaModeCheckBox.Depth = 0;
            this.cinemaModeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.cinemaModeCheckBox.Location = new System.Drawing.Point(164, 17);
            this.cinemaModeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.cinemaModeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cinemaModeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.cinemaModeCheckBox.Name = "cinemaModeCheckBox";
            this.cinemaModeCheckBox.Ripple = true;
            this.cinemaModeCheckBox.Size = new System.Drawing.Size(79, 30);
            this.cinemaModeCheckBox.TabIndex = 1;
            this.cinemaModeCheckBox.Text = "Enabled";
            this.cinemaModeCheckBox.UseVisualStyleBackColor = true;
            this.cinemaModeCheckBox.CheckedChanged += new System.EventHandler(this.cinemaModeCheckbox_Changed);
            // 
            // settingTabPage
            // 
            this.settingTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingTabPage.Controls.Add(this.settingsColorSchemeComboBox);
            this.settingTabPage.Controls.Add(this.settingsThemeComboBox);
            this.settingTabPage.Controls.Add(this.settingsThemeLabel);
            this.settingTabPage.Controls.Add(this.settingsColorSchemeLabel);
            this.settingTabPage.Controls.Add(this.settingsCancelButton);
            this.settingTabPage.Controls.Add(this.settingsSaveButton);
            this.settingTabPage.Controls.Add(this.settingsIpLabel);
            this.settingTabPage.Controls.Add(this.settingsIpTextField);
            this.settingTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingTabPage.Name = "settingTabPage";
            this.settingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingTabPage.Size = new System.Drawing.Size(402, 174);
            this.settingTabPage.TabIndex = 3;
            this.settingTabPage.Text = "Settings";
            // 
            // settingsThemeLabel
            // 
            this.settingsThemeLabel.AutoSize = true;
            this.settingsThemeLabel.Depth = 0;
            this.settingsThemeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingsThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsThemeLabel.Location = new System.Drawing.Point(17, 65);
            this.settingsThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsThemeLabel.Name = "settingsThemeLabel";
            this.settingsThemeLabel.Size = new System.Drawing.Size(55, 19);
            this.settingsThemeLabel.TabIndex = 5;
            this.settingsThemeLabel.Text = "Theme";
            // 
            // settingsColorSchemeLabel
            // 
            this.settingsColorSchemeLabel.AutoSize = true;
            this.settingsColorSchemeLabel.Depth = 0;
            this.settingsColorSchemeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingsColorSchemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsColorSchemeLabel.Location = new System.Drawing.Point(17, 104);
            this.settingsColorSchemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsColorSchemeLabel.Name = "settingsColorSchemeLabel";
            this.settingsColorSchemeLabel.Size = new System.Drawing.Size(104, 19);
            this.settingsColorSchemeLabel.TabIndex = 4;
            this.settingsColorSchemeLabel.Text = "Color Scheme";
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.AutoSize = true;
            this.settingsCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsCancelButton.Depth = 0;
            this.settingsCancelButton.Location = new System.Drawing.Point(9, 131);
            this.settingsCancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Primary = false;
            this.settingsCancelButton.Size = new System.Drawing.Size(64, 36);
            this.settingsCancelButton.TabIndex = 3;
            this.settingsCancelButton.Text = "Cancel";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.AutoSize = true;
            this.settingsSaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsSaveButton.Depth = 0;
            this.settingsSaveButton.Location = new System.Drawing.Point(345, 132);
            this.settingsSaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Primary = false;
            this.settingsSaveButton.Size = new System.Drawing.Size(46, 36);
            this.settingsSaveButton.TabIndex = 2;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.settingsSaveButton_Click);
            // 
            // settingsIpLabel
            // 
            this.settingsIpLabel.AutoSize = true;
            this.settingsIpLabel.Depth = 0;
            this.settingsIpLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingsIpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsIpLabel.Location = new System.Drawing.Point(17, 26);
            this.settingsIpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsIpLabel.Name = "settingsIpLabel";
            this.settingsIpLabel.Size = new System.Drawing.Size(22, 19);
            this.settingsIpLabel.TabIndex = 1;
            this.settingsIpLabel.Text = "IP";
            // 
            // settingsIpTextField
            // 
            this.settingsIpTextField.Depth = 0;
            this.settingsIpTextField.Hint = "";
            this.settingsIpTextField.Location = new System.Drawing.Point(151, 26);
            this.settingsIpTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsIpTextField.Name = "settingsIpTextField";
            this.settingsIpTextField.PasswordChar = '\0';
            this.settingsIpTextField.SelectedText = "";
            this.settingsIpTextField.SelectionLength = 0;
            this.settingsIpTextField.SelectionStart = 0;
            this.settingsIpTextField.Size = new System.Drawing.Size(198, 23);
            this.settingsIpTextField.TabIndex = 0;
            this.settingsIpTextField.Text = "ip address";
            this.settingsIpTextField.UseSystemPasswordChar = false;
            this.settingsIpTextField.TextChanged += new System.EventHandler(this.settingsIpTextField_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(133, 325);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 19);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.brightnessTrackBar.Location = new System.Drawing.Point(29, 145);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(350, 23);
            this.brightnessTrackBar.TabIndex = 6;
            this.brightnessTrackBar.Text = "Brightness";
            this.brightnessTrackBar.Value = 100;
            this.brightnessTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brightnessTrackBar_Scroll);
            // 
            // settingsThemeComboBox
            // 
            this.settingsThemeComboBox.FormattingEnabled = true;
            this.settingsThemeComboBox.ItemHeight = 23;
            this.settingsThemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.settingsThemeComboBox.Location = new System.Drawing.Point(151, 65);
            this.settingsThemeComboBox.Name = "settingsThemeComboBox";
            this.settingsThemeComboBox.Size = new System.Drawing.Size(121, 29);
            this.settingsThemeComboBox.TabIndex = 10;
            this.settingsThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.settingsThemeComboBox_SelectedIndexChanged);
            // 
            // settingsColorSchemeComboBox
            // 
            this.settingsColorSchemeComboBox.FormattingEnabled = true;
            this.settingsColorSchemeComboBox.ItemHeight = 23;
            this.settingsColorSchemeComboBox.Items.AddRange(new object[] {
            "Orange (Default)",
            "BlueGray",
            "Blue",
            "Green",
            "Red"});
            this.settingsColorSchemeComboBox.Location = new System.Drawing.Point(151, 104);
            this.settingsColorSchemeComboBox.Name = "settingsColorSchemeComboBox";
            this.settingsColorSchemeComboBox.Size = new System.Drawing.Size(121, 29);
            this.settingsColorSchemeComboBox.TabIndex = 11;
            this.settingsColorSchemeComboBox.SelectedIndexChanged += new System.EventHandler(this.settingsColorSchemeComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 360);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 360);
            this.MinimumSize = new System.Drawing.Size(408, 360);
            this.Name = "Form1";
            this.Text = "Light";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl.ResumeLayout(false);
            this.normalTabPage.ResumeLayout(false);
            this.normalTabPage.PerformLayout();
            this.rgbTabPage.ResumeLayout(false);
            this.rgbTabPage.PerformLayout();
            this.cinemaTabPage.ResumeLayout(false);
            this.cinemaTabPage.PerformLayout();
            this.settingTabPage.ResumeLayout(false);
            this.settingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog rgbColorDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage normalTabPage;
        private System.Windows.Forms.TabPage rgbTabPage;
        private System.Windows.Forms.TabPage cinemaTabPage;
        private System.Windows.Forms.TabPage settingTabPage;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MaterialSkin.Controls.MaterialRaisedButton onButton;
        private MaterialSkin.Controls.MaterialLabel brightnessLabel;
        private MaterialSkin.Controls.MaterialRaisedButton offButton;
        private MaterialSkin.Controls.MaterialFlatButton colorPickerButton;
        private MaterialSkin.Controls.MaterialLabel statusLabel;
        private MaterialSkin.Controls.MaterialCheckBox cinemaModeCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox cinemaModeLightChekcBox;
        private MaterialSkin.Controls.MaterialFlatButton settingsCancelButton;
        private MaterialSkin.Controls.MaterialFlatButton settingsSaveButton;
        private MaterialSkin.Controls.MaterialLabel settingsIpLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField settingsIpTextField;
        private MaterialSkin.Controls.MaterialLabel settingsThemeLabel;
        private MaterialSkin.Controls.MaterialLabel settingsColorSchemeLabel;
        private MetroFramework.Controls.MetroTrackBar brightnessTrackBar;
        private MetroFramework.Controls.MetroComboBox settingsThemeComboBox;
        private MetroFramework.Controls.MetroComboBox settingsColorSchemeComboBox;
    }
}

