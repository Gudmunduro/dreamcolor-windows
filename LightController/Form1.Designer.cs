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
            this.colorTempTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.colorTempLabel = new MaterialSkin.Controls.MaterialLabel();
            this.brightnessTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.brightnessLabel = new MaterialSkin.Controls.MaterialLabel();
            this.offButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.onButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rgbTabPage = new System.Windows.Forms.TabPage();
            this.rgbBrightnessTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.rgbBrightnessLabel = new MaterialSkin.Controls.MaterialLabel();
            this.colorPickerButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.cinemaTabPage = new System.Windows.Forms.TabPage();
            this.cinemaModeLightChekcBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.cinemaModeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.presetsTabPage = new System.Windows.Forms.TabPage();
            this.presetSpeedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.presetSpeedTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.staticRedRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashWhiteRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.presetStaticLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gradualBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashPurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualGreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.presetMultiColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gradualRedRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashYellowRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualCyanRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.presetGradualLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GradientSevenColorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashCyanRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualYellowRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.presetFlashLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gradientTricolorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashGreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualPurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.jumpingSevenColorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualWhiteRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticCyanRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.jumpingTricolorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flashRedRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualRedBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticGreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticYellowRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.sevenColorStrobeRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualRedGreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticWhiteRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.staticPurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.gradualGreenBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.patternTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.settingsColorSchemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.settingsThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.settingsThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsColorSchemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsSaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsIpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsIpTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsHideOnStartupLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsHideOnStartupCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabControl.SuspendLayout();
            this.normalTabPage.SuspendLayout();
            this.rgbTabPage.SuspendLayout();
            this.cinemaTabPage.SuspendLayout();
            this.presetsTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(604, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "Tabs";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.normalTabPage);
            this.tabControl.Controls.Add(this.rgbTabPage);
            this.tabControl.Controls.Add(this.cinemaTabPage);
            this.tabControl.Controls.Add(this.presetsTabPage);
            this.tabControl.Controls.Add(this.patternTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 117);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(604, 341);
            this.tabControl.TabIndex = 1;
            // 
            // normalTabPage
            // 
            this.normalTabPage.Controls.Add(this.colorTempTrackBar);
            this.normalTabPage.Controls.Add(this.colorTempLabel);
            this.normalTabPage.Controls.Add(this.brightnessTrackBar);
            this.normalTabPage.Controls.Add(this.brightnessLabel);
            this.normalTabPage.Controls.Add(this.offButton);
            this.normalTabPage.Controls.Add(this.onButton);
            this.normalTabPage.Location = new System.Drawing.Point(4, 22);
            this.normalTabPage.Name = "normalTabPage";
            this.normalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.normalTabPage.Size = new System.Drawing.Size(596, 315);
            this.normalTabPage.TabIndex = 0;
            this.normalTabPage.Text = "Normal";
            this.normalTabPage.UseVisualStyleBackColor = true;
            // 
            // colorTempTrackBar
            // 
            this.colorTempTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.colorTempTrackBar.Location = new System.Drawing.Point(25, 176);
            this.colorTempTrackBar.Name = "colorTempTrackBar";
            this.colorTempTrackBar.Size = new System.Drawing.Size(550, 23);
            this.colorTempTrackBar.TabIndex = 9;
            this.colorTempTrackBar.Text = "Brightness";
            this.colorTempTrackBar.Value = 100;
            this.colorTempTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorTempTrackBar_Scroll);
            // 
            // colorTempLabel
            // 
            this.colorTempLabel.AutoSize = true;
            this.colorTempLabel.Depth = 0;
            this.colorTempLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.colorTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorTempLabel.Location = new System.Drawing.Point(232, 145);
            this.colorTempLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorTempLabel.Name = "colorTempLabel";
            this.colorTempLabel.Size = new System.Drawing.Size(135, 19);
            this.colorTempLabel.TabIndex = 8;
            this.colorTempLabel.Text = "Color Temperature";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.brightnessTrackBar.Location = new System.Drawing.Point(25, 110);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(550, 23);
            this.brightnessTrackBar.TabIndex = 6;
            this.brightnessTrackBar.Text = "Brightness";
            this.brightnessTrackBar.Value = 100;
            this.brightnessTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brightnessTrackBar_Scroll);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Depth = 0;
            this.brightnessLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.brightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brightnessLabel.Location = new System.Drawing.Point(260, 79);
            this.brightnessLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(80, 19);
            this.brightnessLabel.TabIndex = 5;
            this.brightnessLabel.Text = "Brightness";
            // 
            // offButton
            // 
            this.offButton.Depth = 0;
            this.offButton.Location = new System.Drawing.Point(329, 41);
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
            this.onButton.Location = new System.Drawing.Point(195, 41);
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
            this.rgbTabPage.Controls.Add(this.rgbBrightnessTrackBar);
            this.rgbTabPage.Controls.Add(this.rgbBrightnessLabel);
            this.rgbTabPage.Controls.Add(this.colorPickerButton);
            this.rgbTabPage.Location = new System.Drawing.Point(4, 22);
            this.rgbTabPage.Name = "rgbTabPage";
            this.rgbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rgbTabPage.Size = new System.Drawing.Size(596, 315);
            this.rgbTabPage.TabIndex = 1;
            this.rgbTabPage.Text = "RGB";
            this.rgbTabPage.UseVisualStyleBackColor = true;
            // 
            // rgbBrightnessTrackBar
            // 
            this.rgbBrightnessTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.rgbBrightnessTrackBar.Location = new System.Drawing.Point(25, 143);
            this.rgbBrightnessTrackBar.Name = "rgbBrightnessTrackBar";
            this.rgbBrightnessTrackBar.Size = new System.Drawing.Size(550, 23);
            this.rgbBrightnessTrackBar.TabIndex = 2;
            this.rgbBrightnessTrackBar.Text = "Brightness";
            this.rgbBrightnessTrackBar.Value = 100;
            this.rgbBrightnessTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rgbBrightnessTrackBar_Scroll);
            // 
            // rgbBrightnessLabel
            // 
            this.rgbBrightnessLabel.AutoSize = true;
            this.rgbBrightnessLabel.Depth = 0;
            this.rgbBrightnessLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.rgbBrightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rgbBrightnessLabel.Location = new System.Drawing.Point(260, 112);
            this.rgbBrightnessLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rgbBrightnessLabel.Name = "rgbBrightnessLabel";
            this.rgbBrightnessLabel.Size = new System.Drawing.Size(80, 19);
            this.rgbBrightnessLabel.TabIndex = 1;
            this.rgbBrightnessLabel.Text = "Brightness";
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.AutoSize = true;
            this.colorPickerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPickerButton.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton.Depth = 0;
            this.colorPickerButton.Location = new System.Drawing.Point(247, 44);
            this.colorPickerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.colorPickerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Primary = true;
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
            this.cinemaTabPage.Size = new System.Drawing.Size(596, 315);
            this.cinemaTabPage.TabIndex = 2;
            this.cinemaTabPage.Text = "Cinema";
            this.cinemaTabPage.UseVisualStyleBackColor = true;
            // 
            // cinemaModeLightChekcBox
            // 
            this.cinemaModeLightChekcBox.AutoSize = true;
            this.cinemaModeLightChekcBox.Depth = 0;
            this.cinemaModeLightChekcBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.cinemaModeLightChekcBox.Location = new System.Drawing.Point(260, 68);
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
            this.cinemaModeCheckBox.Location = new System.Drawing.Point(260, 17);
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
            // presetsTabPage
            // 
            this.presetsTabPage.Controls.Add(this.presetSpeedLabel);
            this.presetsTabPage.Controls.Add(this.presetSpeedTrackBar);
            this.presetsTabPage.Controls.Add(this.staticRedRadioButton);
            this.presetsTabPage.Controls.Add(this.flashWhiteRadioButton);
            this.presetsTabPage.Controls.Add(this.presetStaticLabel);
            this.presetsTabPage.Controls.Add(this.gradualBlueRadioButton);
            this.presetsTabPage.Controls.Add(this.flashPurpleRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualGreenRadioButton);
            this.presetsTabPage.Controls.Add(this.presetMultiColorLabel);
            this.presetsTabPage.Controls.Add(this.gradualRedRadioButton);
            this.presetsTabPage.Controls.Add(this.flashYellowRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualCyanRadioButton);
            this.presetsTabPage.Controls.Add(this.presetGradualLabel);
            this.presetsTabPage.Controls.Add(this.GradientSevenColorRadioButton);
            this.presetsTabPage.Controls.Add(this.flashCyanRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualYellowRadioButton);
            this.presetsTabPage.Controls.Add(this.presetFlashLabel);
            this.presetsTabPage.Controls.Add(this.gradientTricolorRadioButton);
            this.presetsTabPage.Controls.Add(this.flashGreenRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualPurpleRadioButton);
            this.presetsTabPage.Controls.Add(this.staticBlueRadioButton);
            this.presetsTabPage.Controls.Add(this.jumpingSevenColorRadioButton);
            this.presetsTabPage.Controls.Add(this.flashBlueRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualWhiteRadioButton);
            this.presetsTabPage.Controls.Add(this.staticCyanRadioButton);
            this.presetsTabPage.Controls.Add(this.jumpingTricolorRadioButton);
            this.presetsTabPage.Controls.Add(this.flashRedRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualRedBlueRadioButton);
            this.presetsTabPage.Controls.Add(this.staticGreenRadioButton);
            this.presetsTabPage.Controls.Add(this.staticYellowRadioButton);
            this.presetsTabPage.Controls.Add(this.sevenColorStrobeRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualRedGreenRadioButton);
            this.presetsTabPage.Controls.Add(this.staticWhiteRadioButton);
            this.presetsTabPage.Controls.Add(this.staticPurpleRadioButton);
            this.presetsTabPage.Controls.Add(this.gradualGreenBlueRadioButton);
            this.presetsTabPage.Location = new System.Drawing.Point(4, 22);
            this.presetsTabPage.Name = "presetsTabPage";
            this.presetsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.presetsTabPage.Size = new System.Drawing.Size(596, 315);
            this.presetsTabPage.TabIndex = 4;
            this.presetsTabPage.Text = "Pattern";
            this.presetsTabPage.UseVisualStyleBackColor = true;
            // 
            // presetSpeedLabel
            // 
            this.presetSpeedLabel.AutoSize = true;
            this.presetSpeedLabel.Depth = 0;
            this.presetSpeedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.presetSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetSpeedLabel.Location = new System.Drawing.Point(275, 289);
            this.presetSpeedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.presetSpeedLabel.Name = "presetSpeedLabel";
            this.presetSpeedLabel.Size = new System.Drawing.Size(50, 19);
            this.presetSpeedLabel.TabIndex = 35;
            this.presetSpeedLabel.Text = "Speed";
            // 
            // presetSpeedTrackBar
            // 
            this.presetSpeedTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.presetSpeedTrackBar.Location = new System.Drawing.Point(25, 311);
            this.presetSpeedTrackBar.Name = "presetSpeedTrackBar";
            this.presetSpeedTrackBar.Size = new System.Drawing.Size(550, 23);
            this.presetSpeedTrackBar.TabIndex = 34;
            this.presetSpeedTrackBar.Text = "Speed";
            this.presetSpeedTrackBar.Value = 100;
            this.presetSpeedTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedTrackBar_Scroll);
            // 
            // staticRedRadioButton
            // 
            this.staticRedRadioButton.AutoSize = true;
            this.staticRedRadioButton.Depth = 0;
            this.staticRedRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticRedRadioButton.Location = new System.Drawing.Point(15, 44);
            this.staticRedRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticRedRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticRedRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticRedRadioButton.Name = "staticRedRadioButton";
            this.staticRedRadioButton.Ripple = true;
            this.staticRedRadioButton.Size = new System.Drawing.Size(53, 30);
            this.staticRedRadioButton.TabIndex = 4;
            this.staticRedRadioButton.TabStop = true;
            this.staticRedRadioButton.Tag = "StaticRed";
            this.staticRedRadioButton.Text = "Red";
            this.staticRedRadioButton.UseVisualStyleBackColor = true;
            this.staticRedRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashWhiteRadioButton
            // 
            this.flashWhiteRadioButton.AutoSize = true;
            this.flashWhiteRadioButton.Depth = 0;
            this.flashWhiteRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashWhiteRadioButton.Location = new System.Drawing.Point(490, 254);
            this.flashWhiteRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashWhiteRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashWhiteRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashWhiteRadioButton.Name = "flashWhiteRadioButton";
            this.flashWhiteRadioButton.Ripple = true;
            this.flashWhiteRadioButton.Size = new System.Drawing.Size(64, 30);
            this.flashWhiteRadioButton.TabIndex = 33;
            this.flashWhiteRadioButton.TabStop = true;
            this.flashWhiteRadioButton.Tag = "WhiteFlash";
            this.flashWhiteRadioButton.Text = "White";
            this.flashWhiteRadioButton.UseVisualStyleBackColor = true;
            this.flashWhiteRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // presetStaticLabel
            // 
            this.presetStaticLabel.AutoSize = true;
            this.presetStaticLabel.Depth = 0;
            this.presetStaticLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.presetStaticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetStaticLabel.Location = new System.Drawing.Point(56, 16);
            this.presetStaticLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.presetStaticLabel.Name = "presetStaticLabel";
            this.presetStaticLabel.Size = new System.Drawing.Size(48, 19);
            this.presetStaticLabel.TabIndex = 0;
            this.presetStaticLabel.Text = "Static";
            // 
            // gradualBlueRadioButton
            // 
            this.gradualBlueRadioButton.AutoSize = true;
            this.gradualBlueRadioButton.Depth = 0;
            this.gradualBlueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualBlueRadioButton.Location = new System.Drawing.Point(320, 79);
            this.gradualBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualBlueRadioButton.Name = "gradualBlueRadioButton";
            this.gradualBlueRadioButton.Ripple = true;
            this.gradualBlueRadioButton.Size = new System.Drawing.Size(56, 30);
            this.gradualBlueRadioButton.TabIndex = 16;
            this.gradualBlueRadioButton.TabStop = true;
            this.gradualBlueRadioButton.Tag = "BlueGradient";
            this.gradualBlueRadioButton.Text = "Blue";
            this.gradualBlueRadioButton.UseVisualStyleBackColor = true;
            this.gradualBlueRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashPurpleRadioButton
            // 
            this.flashPurpleRadioButton.AutoSize = true;
            this.flashPurpleRadioButton.Depth = 0;
            this.flashPurpleRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashPurpleRadioButton.Location = new System.Drawing.Point(490, 219);
            this.flashPurpleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashPurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashPurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashPurpleRadioButton.Name = "flashPurpleRadioButton";
            this.flashPurpleRadioButton.Ripple = true;
            this.flashPurpleRadioButton.Size = new System.Drawing.Size(69, 30);
            this.flashPurpleRadioButton.TabIndex = 32;
            this.flashPurpleRadioButton.TabStop = true;
            this.flashPurpleRadioButton.Tag = "PurpleFlash";
            this.flashPurpleRadioButton.Text = "Purple";
            this.flashPurpleRadioButton.UseVisualStyleBackColor = true;
            this.flashPurpleRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualGreenRadioButton
            // 
            this.gradualGreenRadioButton.AutoSize = true;
            this.gradualGreenRadioButton.Depth = 0;
            this.gradualGreenRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualGreenRadioButton.Location = new System.Drawing.Point(320, 114);
            this.gradualGreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualGreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualGreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualGreenRadioButton.Name = "gradualGreenRadioButton";
            this.gradualGreenRadioButton.Ripple = true;
            this.gradualGreenRadioButton.Size = new System.Drawing.Size(66, 30);
            this.gradualGreenRadioButton.TabIndex = 17;
            this.gradualGreenRadioButton.TabStop = true;
            this.gradualGreenRadioButton.Tag = "GreenGradient";
            this.gradualGreenRadioButton.Text = "Green";
            this.gradualGreenRadioButton.UseVisualStyleBackColor = true;
            this.gradualGreenRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // presetMultiColorLabel
            // 
            this.presetMultiColorLabel.AutoSize = true;
            this.presetMultiColorLabel.Depth = 0;
            this.presetMultiColorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.presetMultiColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetMultiColorLabel.Location = new System.Drawing.Point(197, 16);
            this.presetMultiColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.presetMultiColorLabel.Name = "presetMultiColorLabel";
            this.presetMultiColorLabel.Size = new System.Drawing.Size(84, 19);
            this.presetMultiColorLabel.TabIndex = 1;
            this.presetMultiColorLabel.Text = "Multi Color";
            // 
            // gradualRedRadioButton
            // 
            this.gradualRedRadioButton.AutoSize = true;
            this.gradualRedRadioButton.Depth = 0;
            this.gradualRedRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualRedRadioButton.Location = new System.Drawing.Point(320, 44);
            this.gradualRedRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualRedRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualRedRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualRedRadioButton.Name = "gradualRedRadioButton";
            this.gradualRedRadioButton.Ripple = true;
            this.gradualRedRadioButton.Size = new System.Drawing.Size(53, 30);
            this.gradualRedRadioButton.TabIndex = 15;
            this.gradualRedRadioButton.TabStop = true;
            this.gradualRedRadioButton.Tag = "RedGradient";
            this.gradualRedRadioButton.Text = "Red";
            this.gradualRedRadioButton.UseVisualStyleBackColor = true;
            this.gradualRedRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashYellowRadioButton
            // 
            this.flashYellowRadioButton.AutoSize = true;
            this.flashYellowRadioButton.Depth = 0;
            this.flashYellowRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashYellowRadioButton.Location = new System.Drawing.Point(490, 184);
            this.flashYellowRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashYellowRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashYellowRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashYellowRadioButton.Name = "flashYellowRadioButton";
            this.flashYellowRadioButton.Ripple = true;
            this.flashYellowRadioButton.Size = new System.Drawing.Size(70, 30);
            this.flashYellowRadioButton.TabIndex = 31;
            this.flashYellowRadioButton.TabStop = true;
            this.flashYellowRadioButton.Tag = "YellowFlash";
            this.flashYellowRadioButton.Text = "Yellow";
            this.flashYellowRadioButton.UseVisualStyleBackColor = true;
            this.flashYellowRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualCyanRadioButton
            // 
            this.gradualCyanRadioButton.AutoSize = true;
            this.gradualCyanRadioButton.Depth = 0;
            this.gradualCyanRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualCyanRadioButton.Location = new System.Drawing.Point(320, 149);
            this.gradualCyanRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualCyanRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualCyanRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualCyanRadioButton.Name = "gradualCyanRadioButton";
            this.gradualCyanRadioButton.Ripple = true;
            this.gradualCyanRadioButton.Size = new System.Drawing.Size(60, 30);
            this.gradualCyanRadioButton.TabIndex = 18;
            this.gradualCyanRadioButton.TabStop = true;
            this.gradualCyanRadioButton.Tag = "CyanGradient";
            this.gradualCyanRadioButton.Text = "Cyan";
            this.gradualCyanRadioButton.UseVisualStyleBackColor = true;
            this.gradualCyanRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // presetGradualLabel
            // 
            this.presetGradualLabel.AutoSize = true;
            this.presetGradualLabel.Depth = 0;
            this.presetGradualLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.presetGradualLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetGradualLabel.Location = new System.Drawing.Point(350, 16);
            this.presetGradualLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.presetGradualLabel.Name = "presetGradualLabel";
            this.presetGradualLabel.Size = new System.Drawing.Size(60, 19);
            this.presetGradualLabel.TabIndex = 2;
            this.presetGradualLabel.Text = "Gradual";
            // 
            // GradientSevenColorRadioButton
            // 
            this.GradientSevenColorRadioButton.AutoSize = true;
            this.GradientSevenColorRadioButton.Depth = 0;
            this.GradientSevenColorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.GradientSevenColorRadioButton.Location = new System.Drawing.Point(180, 149);
            this.GradientSevenColorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.GradientSevenColorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GradientSevenColorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GradientSevenColorRadioButton.Name = "GradientSevenColorRadioButton";
            this.GradientSevenColorRadioButton.Ripple = true;
            this.GradientSevenColorRadioButton.Size = new System.Drawing.Size(127, 30);
            this.GradientSevenColorRadioButton.TabIndex = 14;
            this.GradientSevenColorRadioButton.TabStop = true;
            this.GradientSevenColorRadioButton.Tag = "SevenColorGradient";
            this.GradientSevenColorRadioButton.Text = "7-color gradient";
            this.GradientSevenColorRadioButton.UseVisualStyleBackColor = true;
            this.GradientSevenColorRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashCyanRadioButton
            // 
            this.flashCyanRadioButton.AutoSize = true;
            this.flashCyanRadioButton.Depth = 0;
            this.flashCyanRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashCyanRadioButton.Location = new System.Drawing.Point(490, 149);
            this.flashCyanRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashCyanRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashCyanRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashCyanRadioButton.Name = "flashCyanRadioButton";
            this.flashCyanRadioButton.Ripple = true;
            this.flashCyanRadioButton.Size = new System.Drawing.Size(60, 30);
            this.flashCyanRadioButton.TabIndex = 30;
            this.flashCyanRadioButton.TabStop = true;
            this.flashCyanRadioButton.Tag = "CyanFlash";
            this.flashCyanRadioButton.Text = "Cyan";
            this.flashCyanRadioButton.UseVisualStyleBackColor = true;
            this.flashCyanRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualYellowRadioButton
            // 
            this.gradualYellowRadioButton.AutoSize = true;
            this.gradualYellowRadioButton.Depth = 0;
            this.gradualYellowRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualYellowRadioButton.Location = new System.Drawing.Point(320, 184);
            this.gradualYellowRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualYellowRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualYellowRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualYellowRadioButton.Name = "gradualYellowRadioButton";
            this.gradualYellowRadioButton.Ripple = true;
            this.gradualYellowRadioButton.Size = new System.Drawing.Size(70, 30);
            this.gradualYellowRadioButton.TabIndex = 19;
            this.gradualYellowRadioButton.TabStop = true;
            this.gradualYellowRadioButton.Tag = "YellowGradient";
            this.gradualYellowRadioButton.Text = "Yellow";
            this.gradualYellowRadioButton.UseVisualStyleBackColor = true;
            this.gradualYellowRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // presetFlashLabel
            // 
            this.presetFlashLabel.AutoSize = true;
            this.presetFlashLabel.Depth = 0;
            this.presetFlashLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.presetFlashLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetFlashLabel.Location = new System.Drawing.Point(507, 16);
            this.presetFlashLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.presetFlashLabel.Name = "presetFlashLabel";
            this.presetFlashLabel.Size = new System.Drawing.Size(45, 19);
            this.presetFlashLabel.TabIndex = 3;
            this.presetFlashLabel.Text = "Flash";
            // 
            // gradientTricolorRadioButton
            // 
            this.gradientTricolorRadioButton.AutoSize = true;
            this.gradientTricolorRadioButton.Depth = 0;
            this.gradientTricolorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradientTricolorRadioButton.Location = new System.Drawing.Point(180, 114);
            this.gradientTricolorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradientTricolorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradientTricolorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradientTricolorRadioButton.Name = "gradientTricolorRadioButton";
            this.gradientTricolorRadioButton.Ripple = true;
            this.gradientTricolorRadioButton.Size = new System.Drawing.Size(131, 30);
            this.gradientTricolorRadioButton.TabIndex = 13;
            this.gradientTricolorRadioButton.TabStop = true;
            this.gradientTricolorRadioButton.Tag = "TricolorGradient";
            this.gradientTricolorRadioButton.Text = "Tricolor gradient";
            this.gradientTricolorRadioButton.UseVisualStyleBackColor = true;
            this.gradientTricolorRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashGreenRadioButton
            // 
            this.flashGreenRadioButton.AutoSize = true;
            this.flashGreenRadioButton.Depth = 0;
            this.flashGreenRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashGreenRadioButton.Location = new System.Drawing.Point(490, 114);
            this.flashGreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashGreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashGreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashGreenRadioButton.Name = "flashGreenRadioButton";
            this.flashGreenRadioButton.Ripple = true;
            this.flashGreenRadioButton.Size = new System.Drawing.Size(66, 30);
            this.flashGreenRadioButton.TabIndex = 29;
            this.flashGreenRadioButton.TabStop = true;
            this.flashGreenRadioButton.Tag = "GreenFlash";
            this.flashGreenRadioButton.Text = "Green";
            this.flashGreenRadioButton.UseVisualStyleBackColor = true;
            this.flashGreenRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualPurpleRadioButton
            // 
            this.gradualPurpleRadioButton.AutoSize = true;
            this.gradualPurpleRadioButton.Depth = 0;
            this.gradualPurpleRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualPurpleRadioButton.Location = new System.Drawing.Point(320, 219);
            this.gradualPurpleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualPurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualPurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualPurpleRadioButton.Name = "gradualPurpleRadioButton";
            this.gradualPurpleRadioButton.Ripple = true;
            this.gradualPurpleRadioButton.Size = new System.Drawing.Size(69, 30);
            this.gradualPurpleRadioButton.TabIndex = 20;
            this.gradualPurpleRadioButton.TabStop = true;
            this.gradualPurpleRadioButton.Tag = "PurpleGradient";
            this.gradualPurpleRadioButton.Text = "Purple";
            this.gradualPurpleRadioButton.UseVisualStyleBackColor = true;
            this.gradualPurpleRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticBlueRadioButton
            // 
            this.staticBlueRadioButton.AutoSize = true;
            this.staticBlueRadioButton.Depth = 0;
            this.staticBlueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticBlueRadioButton.Location = new System.Drawing.Point(15, 79);
            this.staticBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticBlueRadioButton.Name = "staticBlueRadioButton";
            this.staticBlueRadioButton.Ripple = true;
            this.staticBlueRadioButton.Size = new System.Drawing.Size(56, 30);
            this.staticBlueRadioButton.TabIndex = 5;
            this.staticBlueRadioButton.TabStop = true;
            this.staticBlueRadioButton.Tag = "StaticBlue";
            this.staticBlueRadioButton.Text = "Blue";
            this.staticBlueRadioButton.UseVisualStyleBackColor = true;
            this.staticBlueRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // jumpingSevenColorRadioButton
            // 
            this.jumpingSevenColorRadioButton.AutoSize = true;
            this.jumpingSevenColorRadioButton.Depth = 0;
            this.jumpingSevenColorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.jumpingSevenColorRadioButton.Location = new System.Drawing.Point(180, 79);
            this.jumpingSevenColorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.jumpingSevenColorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.jumpingSevenColorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jumpingSevenColorRadioButton.Name = "jumpingSevenColorRadioButton";
            this.jumpingSevenColorRadioButton.Ripple = true;
            this.jumpingSevenColorRadioButton.Size = new System.Drawing.Size(107, 30);
            this.jumpingSevenColorRadioButton.TabIndex = 12;
            this.jumpingSevenColorRadioButton.TabStop = true;
            this.jumpingSevenColorRadioButton.Tag = "SevenColorJump";
            this.jumpingSevenColorRadioButton.Text = "7-color jump";
            this.jumpingSevenColorRadioButton.UseVisualStyleBackColor = true;
            this.jumpingSevenColorRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashBlueRadioButton
            // 
            this.flashBlueRadioButton.AutoSize = true;
            this.flashBlueRadioButton.Depth = 0;
            this.flashBlueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashBlueRadioButton.Location = new System.Drawing.Point(490, 79);
            this.flashBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashBlueRadioButton.Name = "flashBlueRadioButton";
            this.flashBlueRadioButton.Ripple = true;
            this.flashBlueRadioButton.Size = new System.Drawing.Size(56, 30);
            this.flashBlueRadioButton.TabIndex = 28;
            this.flashBlueRadioButton.TabStop = true;
            this.flashBlueRadioButton.Tag = "BlueFlash";
            this.flashBlueRadioButton.Text = "Blue";
            this.flashBlueRadioButton.UseVisualStyleBackColor = true;
            this.flashBlueRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualWhiteRadioButton
            // 
            this.gradualWhiteRadioButton.AutoSize = true;
            this.gradualWhiteRadioButton.Depth = 0;
            this.gradualWhiteRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualWhiteRadioButton.Location = new System.Drawing.Point(320, 254);
            this.gradualWhiteRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualWhiteRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualWhiteRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualWhiteRadioButton.Name = "gradualWhiteRadioButton";
            this.gradualWhiteRadioButton.Ripple = true;
            this.gradualWhiteRadioButton.Size = new System.Drawing.Size(64, 30);
            this.gradualWhiteRadioButton.TabIndex = 21;
            this.gradualWhiteRadioButton.TabStop = true;
            this.gradualWhiteRadioButton.Tag = "WhiteGradient";
            this.gradualWhiteRadioButton.Text = "White";
            this.gradualWhiteRadioButton.UseVisualStyleBackColor = true;
            this.gradualWhiteRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticCyanRadioButton
            // 
            this.staticCyanRadioButton.AutoSize = true;
            this.staticCyanRadioButton.Depth = 0;
            this.staticCyanRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticCyanRadioButton.Location = new System.Drawing.Point(15, 149);
            this.staticCyanRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticCyanRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticCyanRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticCyanRadioButton.Name = "staticCyanRadioButton";
            this.staticCyanRadioButton.Ripple = true;
            this.staticCyanRadioButton.Size = new System.Drawing.Size(60, 30);
            this.staticCyanRadioButton.TabIndex = 6;
            this.staticCyanRadioButton.TabStop = true;
            this.staticCyanRadioButton.Tag = "StaticCyan";
            this.staticCyanRadioButton.Text = "Cyan";
            this.staticCyanRadioButton.UseVisualStyleBackColor = true;
            this.staticCyanRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // jumpingTricolorRadioButton
            // 
            this.jumpingTricolorRadioButton.AutoSize = true;
            this.jumpingTricolorRadioButton.Depth = 0;
            this.jumpingTricolorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.jumpingTricolorRadioButton.Location = new System.Drawing.Point(180, 44);
            this.jumpingTricolorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.jumpingTricolorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.jumpingTricolorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jumpingTricolorRadioButton.Name = "jumpingTricolorRadioButton";
            this.jumpingTricolorRadioButton.Ripple = true;
            this.jumpingTricolorRadioButton.Size = new System.Drawing.Size(111, 30);
            this.jumpingTricolorRadioButton.TabIndex = 11;
            this.jumpingTricolorRadioButton.TabStop = true;
            this.jumpingTricolorRadioButton.Tag = "TricolorJump";
            this.jumpingTricolorRadioButton.Text = "Tricolor jump";
            this.jumpingTricolorRadioButton.UseVisualStyleBackColor = true;
            this.jumpingTricolorRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // flashRedRadioButton
            // 
            this.flashRedRadioButton.AutoSize = true;
            this.flashRedRadioButton.Depth = 0;
            this.flashRedRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flashRedRadioButton.Location = new System.Drawing.Point(490, 44);
            this.flashRedRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flashRedRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flashRedRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashRedRadioButton.Name = "flashRedRadioButton";
            this.flashRedRadioButton.Ripple = true;
            this.flashRedRadioButton.Size = new System.Drawing.Size(53, 30);
            this.flashRedRadioButton.TabIndex = 27;
            this.flashRedRadioButton.TabStop = true;
            this.flashRedRadioButton.Tag = "RedFlash";
            this.flashRedRadioButton.Text = "Red";
            this.flashRedRadioButton.UseVisualStyleBackColor = true;
            this.flashRedRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualRedBlueRadioButton
            // 
            this.gradualRedBlueRadioButton.AutoSize = true;
            this.gradualRedBlueRadioButton.Depth = 0;
            this.gradualRedBlueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualRedBlueRadioButton.Location = new System.Drawing.Point(395, 79);
            this.gradualRedBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualRedBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualRedBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualRedBlueRadioButton.Name = "gradualRedBlueRadioButton";
            this.gradualRedBlueRadioButton.Ripple = true;
            this.gradualRedBlueRadioButton.Size = new System.Drawing.Size(83, 30);
            this.gradualRedBlueRadioButton.TabIndex = 22;
            this.gradualRedBlueRadioButton.TabStop = true;
            this.gradualRedBlueRadioButton.Tag = "RedBlueGradient";
            this.gradualRedBlueRadioButton.Text = "Red-blue";
            this.gradualRedBlueRadioButton.UseVisualStyleBackColor = true;
            this.gradualRedBlueRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticGreenRadioButton
            // 
            this.staticGreenRadioButton.AutoSize = true;
            this.staticGreenRadioButton.Depth = 0;
            this.staticGreenRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticGreenRadioButton.Location = new System.Drawing.Point(15, 114);
            this.staticGreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticGreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticGreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticGreenRadioButton.Name = "staticGreenRadioButton";
            this.staticGreenRadioButton.Ripple = true;
            this.staticGreenRadioButton.Size = new System.Drawing.Size(66, 30);
            this.staticGreenRadioButton.TabIndex = 7;
            this.staticGreenRadioButton.TabStop = true;
            this.staticGreenRadioButton.Tag = "StaticGreen";
            this.staticGreenRadioButton.Text = "Green";
            this.staticGreenRadioButton.UseVisualStyleBackColor = true;
            this.staticGreenRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticYellowRadioButton
            // 
            this.staticYellowRadioButton.AutoSize = true;
            this.staticYellowRadioButton.Depth = 0;
            this.staticYellowRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticYellowRadioButton.Location = new System.Drawing.Point(15, 184);
            this.staticYellowRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticYellowRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticYellowRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticYellowRadioButton.Name = "staticYellowRadioButton";
            this.staticYellowRadioButton.Ripple = true;
            this.staticYellowRadioButton.Size = new System.Drawing.Size(70, 30);
            this.staticYellowRadioButton.TabIndex = 10;
            this.staticYellowRadioButton.TabStop = true;
            this.staticYellowRadioButton.Tag = "StaticYellow";
            this.staticYellowRadioButton.Text = "Yellow";
            this.staticYellowRadioButton.UseVisualStyleBackColor = true;
            this.staticYellowRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // sevenColorStrobeRadioButton
            // 
            this.sevenColorStrobeRadioButton.AutoSize = true;
            this.sevenColorStrobeRadioButton.Depth = 0;
            this.sevenColorStrobeRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.sevenColorStrobeRadioButton.Location = new System.Drawing.Point(180, 184);
            this.sevenColorStrobeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.sevenColorStrobeRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sevenColorStrobeRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sevenColorStrobeRadioButton.Name = "sevenColorStrobeRadioButton";
            this.sevenColorStrobeRadioButton.Ripple = true;
            this.sevenColorStrobeRadioButton.Size = new System.Drawing.Size(115, 30);
            this.sevenColorStrobeRadioButton.TabIndex = 26;
            this.sevenColorStrobeRadioButton.TabStop = true;
            this.sevenColorStrobeRadioButton.Tag = "SevenColorFlash";
            this.sevenColorStrobeRadioButton.Text = "7-color strobe";
            this.sevenColorStrobeRadioButton.UseVisualStyleBackColor = true;
            this.sevenColorStrobeRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualRedGreenRadioButton
            // 
            this.gradualRedGreenRadioButton.AutoSize = true;
            this.gradualRedGreenRadioButton.Depth = 0;
            this.gradualRedGreenRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualRedGreenRadioButton.Location = new System.Drawing.Point(395, 44);
            this.gradualRedGreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualRedGreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualRedGreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualRedGreenRadioButton.Name = "gradualRedGreenRadioButton";
            this.gradualRedGreenRadioButton.Ripple = true;
            this.gradualRedGreenRadioButton.Size = new System.Drawing.Size(89, 30);
            this.gradualRedGreenRadioButton.TabIndex = 23;
            this.gradualRedGreenRadioButton.TabStop = true;
            this.gradualRedGreenRadioButton.Tag = "RedGreenGradient";
            this.gradualRedGreenRadioButton.Text = "RedGreen";
            this.gradualRedGreenRadioButton.UseVisualStyleBackColor = true;
            this.gradualRedGreenRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticWhiteRadioButton
            // 
            this.staticWhiteRadioButton.AutoSize = true;
            this.staticWhiteRadioButton.Depth = 0;
            this.staticWhiteRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticWhiteRadioButton.Location = new System.Drawing.Point(15, 254);
            this.staticWhiteRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticWhiteRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticWhiteRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticWhiteRadioButton.Name = "staticWhiteRadioButton";
            this.staticWhiteRadioButton.Ripple = true;
            this.staticWhiteRadioButton.Size = new System.Drawing.Size(64, 30);
            this.staticWhiteRadioButton.TabIndex = 8;
            this.staticWhiteRadioButton.TabStop = true;
            this.staticWhiteRadioButton.Tag = "StaticWhite";
            this.staticWhiteRadioButton.Text = "White";
            this.staticWhiteRadioButton.UseVisualStyleBackColor = true;
            this.staticWhiteRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // staticPurpleRadioButton
            // 
            this.staticPurpleRadioButton.AutoSize = true;
            this.staticPurpleRadioButton.Depth = 0;
            this.staticPurpleRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.staticPurpleRadioButton.Location = new System.Drawing.Point(15, 219);
            this.staticPurpleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.staticPurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.staticPurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.staticPurpleRadioButton.Name = "staticPurpleRadioButton";
            this.staticPurpleRadioButton.Ripple = true;
            this.staticPurpleRadioButton.Size = new System.Drawing.Size(69, 30);
            this.staticPurpleRadioButton.TabIndex = 9;
            this.staticPurpleRadioButton.TabStop = true;
            this.staticPurpleRadioButton.Tag = "StaticPurple";
            this.staticPurpleRadioButton.Text = "Purple";
            this.staticPurpleRadioButton.UseVisualStyleBackColor = true;
            this.staticPurpleRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // gradualGreenBlueRadioButton
            // 
            this.gradualGreenBlueRadioButton.AutoSize = true;
            this.gradualGreenBlueRadioButton.Depth = 0;
            this.gradualGreenBlueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.gradualGreenBlueRadioButton.Location = new System.Drawing.Point(395, 114);
            this.gradualGreenBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.gradualGreenBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gradualGreenBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradualGreenBlueRadioButton.Name = "gradualGreenBlueRadioButton";
            this.gradualGreenBlueRadioButton.Ripple = true;
            this.gradualGreenBlueRadioButton.Size = new System.Drawing.Size(93, 30);
            this.gradualGreenBlueRadioButton.TabIndex = 25;
            this.gradualGreenBlueRadioButton.TabStop = true;
            this.gradualGreenBlueRadioButton.Tag = "GreenBlueGradient";
            this.gradualGreenBlueRadioButton.Text = "GreenBlue";
            this.gradualGreenBlueRadioButton.UseVisualStyleBackColor = true;
            this.gradualGreenBlueRadioButton.CheckedChanged += new System.EventHandler(this.presetRadioButton_Changed);
            // 
            // patternTabPage
            // 
            this.patternTabPage.Location = new System.Drawing.Point(4, 22);
            this.patternTabPage.Name = "patternTabPage";
            this.patternTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patternTabPage.Size = new System.Drawing.Size(596, 315);
            this.patternTabPage.TabIndex = 5;
            this.patternTabPage.Text = "Settings";
            this.patternTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsTabPage.Controls.Add(this.settingsHideOnStartupCheckBox);
            this.settingsTabPage.Controls.Add(this.settingsHideOnStartupLabel);
            this.settingsTabPage.Controls.Add(this.settingsColorSchemeComboBox);
            this.settingsTabPage.Controls.Add(this.settingsThemeComboBox);
            this.settingsTabPage.Controls.Add(this.settingsThemeLabel);
            this.settingsTabPage.Controls.Add(this.settingsColorSchemeLabel);
            this.settingsTabPage.Controls.Add(this.settingsCancelButton);
            this.settingsTabPage.Controls.Add(this.settingsSaveButton);
            this.settingsTabPage.Controls.Add(this.settingsIpLabel);
            this.settingsTabPage.Controls.Add(this.settingsIpTextField);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(596, 315);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Presets";
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
            this.settingsColorSchemeComboBox.Location = new System.Drawing.Point(385, 100);
            this.settingsColorSchemeComboBox.Name = "settingsColorSchemeComboBox";
            this.settingsColorSchemeComboBox.Size = new System.Drawing.Size(121, 29);
            this.settingsColorSchemeComboBox.TabIndex = 11;
            this.settingsColorSchemeComboBox.SelectedIndexChanged += new System.EventHandler(this.settingsColorSchemeComboBox_SelectedIndexChanged);
            // 
            // settingsThemeComboBox
            // 
            this.settingsThemeComboBox.FormattingEnabled = true;
            this.settingsThemeComboBox.ItemHeight = 23;
            this.settingsThemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.settingsThemeComboBox.Location = new System.Drawing.Point(385, 61);
            this.settingsThemeComboBox.Name = "settingsThemeComboBox";
            this.settingsThemeComboBox.Size = new System.Drawing.Size(121, 29);
            this.settingsThemeComboBox.TabIndex = 10;
            this.settingsThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.settingsThemeComboBox_SelectedIndexChanged);
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
            this.settingsCancelButton.Location = new System.Drawing.Point(9, 287);
            this.settingsCancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Primary = true;
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
            this.settingsSaveButton.Location = new System.Drawing.Point(537, 287);
            this.settingsSaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Primary = true;
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
            this.settingsIpTextField.Location = new System.Drawing.Point(385, 26);
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
            this.statusLabel.Location = new System.Drawing.Point(231, 457);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 19);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // settingsHideOnStartupLabel
            // 
            this.settingsHideOnStartupLabel.AutoSize = true;
            this.settingsHideOnStartupLabel.Depth = 0;
            this.settingsHideOnStartupLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.settingsHideOnStartupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsHideOnStartupLabel.Location = new System.Drawing.Point(17, 143);
            this.settingsHideOnStartupLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsHideOnStartupLabel.Name = "settingsHideOnStartupLabel";
            this.settingsHideOnStartupLabel.Size = new System.Drawing.Size(112, 19);
            this.settingsHideOnStartupLabel.TabIndex = 12;
            this.settingsHideOnStartupLabel.Text = "Hide on startup";
            // 
            // settingsHideOnStartupCheckBox
            // 
            this.settingsHideOnStartupCheckBox.AutoSize = true;
            this.settingsHideOnStartupCheckBox.Depth = 0;
            this.settingsHideOnStartupCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.settingsHideOnStartupCheckBox.Location = new System.Drawing.Point(380, 137);
            this.settingsHideOnStartupCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.settingsHideOnStartupCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.settingsHideOnStartupCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsHideOnStartupCheckBox.Name = "settingsHideOnStartupCheckBox";
            this.settingsHideOnStartupCheckBox.Ripple = true;
            this.settingsHideOnStartupCheckBox.Size = new System.Drawing.Size(26, 30);
            this.settingsHideOnStartupCheckBox.TabIndex = 13;
            this.settingsHideOnStartupCheckBox.UseVisualStyleBackColor = true;
            this.settingsHideOnStartupCheckBox.CheckedChanged += new System.EventHandler(this.settingsHideOnStartupCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(600, 480);
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
            this.presetsTabPage.ResumeLayout(false);
            this.presetsTabPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
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
        private System.Windows.Forms.TabPage settingsTabPage;
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
        private MetroFramework.Controls.MetroTrackBar colorTempTrackBar;
        private MaterialSkin.Controls.MaterialLabel colorTempLabel;
        private MetroFramework.Controls.MetroTrackBar rgbBrightnessTrackBar;
        private MaterialSkin.Controls.MaterialLabel rgbBrightnessLabel;
        private System.Windows.Forms.TabPage presetsTabPage;
        private System.Windows.Forms.TabPage patternTabPage;
        private MaterialSkin.Controls.MaterialLabel presetFlashLabel;
        private MaterialSkin.Controls.MaterialLabel presetGradualLabel;
        private MaterialSkin.Controls.MaterialLabel presetMultiColorLabel;
        private MaterialSkin.Controls.MaterialLabel presetStaticLabel;
        private MaterialSkin.Controls.MaterialRadioButton staticYellowRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticPurpleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticWhiteRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticGreenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticCyanRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton staticRedRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton jumpingTricolorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton jumpingSevenColorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton GradientSevenColorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradientTricolorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualRedRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualRedBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualWhiteRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualPurpleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualYellowRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualCyanRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualGreenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualGreenBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton gradualRedGreenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashCyanRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashGreenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashRedRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton sevenColorStrobeRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashWhiteRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashPurpleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flashYellowRadioButton;
        private MaterialSkin.Controls.MaterialLabel presetSpeedLabel;
        private MetroFramework.Controls.MetroTrackBar presetSpeedTrackBar;
        private MaterialSkin.Controls.MaterialCheckBox settingsHideOnStartupCheckBox;
        private MaterialSkin.Controls.MaterialLabel settingsHideOnStartupLabel;
    }
}

