using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework.Controls;

namespace LightController
{
    public partial class Form1 : MaterialForm
    {
        private Light light;
        private Settings settings;
        public Form1()
        {
            InitializeComponent();
            settings = new Settings();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = settings.theme;
            materialSkinManager.ColorScheme = settings.colorScheme;

            light = new Light(settings.ip);
            if (light.isConnected)
            {
                status = "Connected";
            }
            else
            {
                status = "Connection failed";
            }
            cinemaController = new CinemaModeController(light);
            setNormalContextMenu();

            settingsIpTextField.Text = settings.ip;
            settingsColorSchemeComboBox.SelectedIndex = settings.colorSchemeIndex;
            settingsThemeComboBox.SelectedIndex = settings.themeIndex;

            staticRedRadioButton.CheckedChanged -= presetRadioButton_Changed;
            staticRedRadioButton.Checked = true;
            staticRedRadioButton.CheckedChanged += presetRadioButton_Changed;


        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        // all

        public string status
        {
            set { statusLabel.Text = "Status: " + value; }
            get { return statusLabel.Text.Substring(8); }
        }

        public void onChange()
        {
            if (cinemaController.enabled)
            {
                cinemaController.disableWithoutChange();
                uncheckCinemaLightCheckbox();
                unCheckCinemaModeCheckbox();
                setNormalContextMenu();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == normalTabPage)
            {

            }
            else if (tabControl.SelectedTab == rgbTabPage)
            {

            }
            else if (tabControl.SelectedTab == cinemaTabPage)
            {
                cinemaModeCheckBox.Checked = cinemaController.enabled;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                
            }
        }

        // Normal

        private void onButton_Click(object sender, EventArgs e)
        {
            light.on();
            onChange();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            light.off();
            onChange();
        }

        private void brightnessTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (colorTempTrackBar.Value == 100)
            {
                light.dim(brightnessTrackBar.Value / 10);
            }
            else
            {
                light.brightness(brightnessTrackBar.Value);
            }
            rgbBrightnessTrackBar.Value = brightnessTrackBar.Value;
            onChange();
        }

        private void colorTempTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (brightnessTrackBar.Value != 100)
            {
                light.brightness(brightnessTrackBar.Value);
            }
            light.temp(colorTempTrackBar.Value / 10);
            onChange();
        }

        // RGB

        Color rgbColor = Color.FromArgb(255, 255, 255);

        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            rgbColorDialog.ShowDialog();
            rgbColor = rgbColorDialog.Color;
            light.rgb(rgbColor.R, rgbColor.G, rgbColor.B);
            onChange();
        }

        private void rgbBrightnessTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            light.brightness(rgbBrightnessTrackBar.Value);
            brightnessTrackBar.Value = rgbBrightnessTrackBar.Value;
            onChange();
        }

        // Cinema

        private CinemaModeController cinemaController;

        private void uncheckCinemaLightCheckbox()
        {
            if (cinemaModeLightChekcBox.Checked)
            {
                cinemaModeLightChekcBox.CheckedChanged -= cinemaModeLightCheckbox_Changed;
                cinemaModeLightChekcBox.Checked = false;
                cinemaModeLightChekcBox.CheckedChanged += cinemaModeLightCheckbox_Changed;
            }
        }

        private void unCheckCinemaModeCheckbox()
        {
            if (cinemaModeCheckBox.Checked)
            {
                cinemaModeCheckBox.CheckedChanged -= cinemaModeCheckbox_Changed;
                cinemaModeCheckBox.Checked = false;
                cinemaModeCheckBox.CheckedChanged += cinemaModeCheckbox_Changed;
            }
        }

        private void cinemaModeLightCheckbox_Changed(object sender, EventArgs e)
        {
            if (cinemaController.enabled)
            {
                cinemaController.lightOn = cinemaModeLightChekcBox.Checked;
            }
            else
            {
                if (cinemaModeLightChekcBox.Checked)
                {
                    MessageBox.Show("Enable cinema mode first");
                    cinemaModeLightChekcBox.Checked = false;
                }
            }
        }

        private void cinemaModeCheckbox_Changed(object sender, EventArgs e)
        {
            uncheckCinemaLightCheckbox();
            if (cinemaModeCheckBox.Checked)
            {
                cinemaController.enabled = true;
                setCinemaContextMenu();
            }
            else
            {
                cinemaController.enabled = false;
                setNormalContextMenu();
            }
        }

        // presets

        private void presetRadioButton_Changed(object sender, EventArgs e)
        {
            RadioButton senderRadioButton = (RadioButton)sender;
            if (senderRadioButton.Checked)
            {
                Enum.TryParse(senderRadioButton.Tag.ToString(), out PresetMode mode);
                light.preset(mode);
            }
            onChange();
        }

        // pattern

        private void speedTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            MetroTrackBar senderTrackBar = (MetroTrackBar)sender;
            if (senderTrackBar.Value != presetSpeedTrackBar.Value)
            {

            }
            light.speed(senderTrackBar.Value * 2);
            onChange();
        }

        // Settings

        private void settingsIpTextField_TextChanged(object sender, EventArgs e)
        {
            setSaveAndCancelEnabled();
        }

        private void settingsThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveAndCancelEnabled();
        }

        private void settingsColorSchemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveAndCancelEnabled();
        }

        private void setSaveAndCancelEnabled()
        {
            if (settingsIpTextField.Text == settings.ip &&
                settingsColorSchemeComboBox.SelectedIndex == settings.colorSchemeIndex &&
                settingsThemeComboBox.SelectedIndex == settings.themeIndex)
            {
                settingsCancelButton.Enabled = false;
                settingsSaveButton.Enabled = false;
            }
            else
            {
                settingsCancelButton.Enabled = true;
                settingsSaveButton.Enabled = true;
            }
        }

        private void settingsCancelButton_Click(object sender, EventArgs e)
        {
            settingsIpTextField.Text = settings.ip;
            settingsColorSchemeComboBox.SelectedIndex = settings.colorSchemeIndex;
            settingsThemeComboBox.SelectedIndex = settings.themeIndex;
        }

        private void settingsSaveButton_Click(object sender, EventArgs e)
        {
            settings.ip = settingsIpTextField.Text;
            settings.colorSchemeIndex = settingsColorSchemeComboBox.SelectedIndex;
            settings.themeIndex = settingsThemeComboBox.SelectedIndex;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = settings.colorScheme;
            materialSkinManager.Theme = settings.theme;

            light = new Light(settings.ip);
            if (light.isConnected)
            {
                status = "Connected";
            }
            else
            {
                status = "Connection failed";
            }

            settingsCancelButton.Enabled = false;
            settingsSaveButton.Enabled = false;
        }

        // Context menu

        private void setNormalContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Show", showWindowEvent);
            menu.MenuItems.Add("On", lightOnEvent);
            menu.MenuItems.Add("Off", lightOffEvent);
            menu.MenuItems.Add("RGB", setRGBEvent);
            menu.MenuItems.Add("Cinema Mode", cinemaModeEvent);
            notifyIcon.ContextMenu = menu;
        }

        private void setCinemaContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Show", showWindowEvent);
            menu.MenuItems.Add("Light on", cinemaLightOnEvent);
            menu.MenuItems.Add("Light off", cinemaLightOffEvent);
            menu.MenuItems.Add("Disable cinema mode", cinemaModeEvent);
            notifyIcon.ContextMenu = menu;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            MethodInfo methodInfo = typeof(NotifyIcon).GetMethod("ShowContextMenu",
            BindingFlags.Instance | BindingFlags.NonPublic);

            methodInfo.Invoke(this.notifyIcon, null);
        }

        private void showWindowEvent(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void lightOnEvent(object sender, EventArgs e)
        {
            light.on();
        }

        private void lightOffEvent(object sender, EventArgs e)
        {
            light.off();
        }

        private void setRGBEvent(object sender, EventArgs e)
        {
            rgbColorDialog.ShowDialog();
            rgbColor = rgbColorDialog.Color;
            light.rgb(rgbColor.R, rgbColor.G, rgbColor.B);
            onChange();
        }

        private void cinemaModeEvent(object sender, EventArgs e)
        {
            uncheckCinemaLightCheckbox();
            if (!cinemaController.enabled)
            {
                cinemaController.enabled = true;
                cinemaModeCheckBox.Checked = true;
                setCinemaContextMenu();
            }
            else
            {
                cinemaController.enabled = false;
                cinemaModeCheckBox.Checked = false;
                setNormalContextMenu();
            }
        }

        private void cinemaLightOnEvent(object sender, EventArgs e)
        {
            cinemaModeLightChekcBox.Checked = true;
        }

        private void cinemaLightOffEvent(object sender, EventArgs e)
        {
            cinemaModeLightChekcBox.Checked = false;
        }
    }
}
