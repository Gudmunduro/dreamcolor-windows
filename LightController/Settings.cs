using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using MaterialSkin;

namespace LightController
{
    class Settings
    {
        private RegistryKey regKey;
        private string ipVar;
        private MaterialSkinManager.Themes themeVar;
        private Primary colorSchemePrimaryVar;
        private Primary colorSchemeLightPrimaryVar;
        private Primary colorSchemeDarkPrimaryVar;
        private Accent colorSchemeAccentPrimaryVar;
        private TextShade colorSchemeTextShadeVar;
        private int colorSchemeIndexVar;
        private bool hideOnStartupVar;

        public Settings()
        {
            var key = Registry.CurrentUser;
            key = createAndGetSubkey(key, "Software");
            key = createAndGetSubkey(key, "LightController");
            key = createAndGetSubkey(key, "0.1");

            createAndSetKeyIfNotExists(key, "ip");
            createAndSetKeyIfNotExists(key, "theme");
            createAndSetKeyIfNotExists(key, "colorSchemePrimary");
            createAndSetKeyIfNotExists(key, "colorSchemeLightPrimary");
            createAndSetKeyIfNotExists(key, "colorSchemeDarkPrimary");
            createAndSetKeyIfNotExists(key, "colorSchemeAccentPrimary");
            createAndSetKeyIfNotExists(key, "colorSchemeTextShade");
            createAndSetKeyIfNotExists(key, "colorSchemeIndex");
            createAndSetKeyIfNotExists(key, "hideOnStartup");

            Enum.TryParse((string)key.GetValue("theme"), out MaterialSkinManager.Themes themeVar);
            Enum.TryParse((string)key.GetValue("colorSchemePrimary"), out Primary colorSchemePrimaryVar);
            Enum.TryParse((string)key.GetValue("colorSchemeLightPrimary"), out Primary colorSchemeLightPrimaryVar);
            Enum.TryParse((string)key.GetValue("colorSchemeDarkPrimary"), out Primary colorSchemeDarkPrimaryVar);
            Enum.TryParse((string)key.GetValue("colorSchemeAccentPrimary"), out Accent colorSchemeAccentPrimaryVar);
            Enum.TryParse((string)key.GetValue("colorSchemeTextShade"), out TextShade colorSchemeTextShadeVar);

            this.ipVar = (string)key.GetValue("ip");
            this.colorSchemeIndexVar = Convert.ToInt32(key.GetValue("colorSchemeIndex").ToString());
            this.hideOnStartupVar = Convert2.stringToBool(key.GetValue("hideOnStartup").ToString());
            this.themeVar = themeVar;
            this.colorSchemePrimaryVar = colorSchemePrimaryVar;
            this.colorSchemeLightPrimaryVar = colorSchemeLightPrimaryVar;
            this.colorSchemeDarkPrimaryVar = colorSchemeDarkPrimaryVar;
            this.colorSchemeAccentPrimaryVar = colorSchemeAccentPrimaryVar;
            this.colorSchemeTextShadeVar = colorSchemeTextShadeVar;
            this.themeVar = themeVar;

            this.regKey = key;
        }

        public string ip
        {
            get { return ipVar; }
            set { ipVar = value; regKey.SetValue("ip", ipVar, RegistryValueKind.String); }
        }

        public ColorScheme colorScheme
        {
            get { return new ColorScheme(colorSchemePrimaryVar, colorSchemeDarkPrimaryVar, colorSchemeLightPrimaryVar, colorSchemeAccentPrimaryVar, colorSchemeTextShadeVar); }
        }

        public MaterialSkinManager.Themes theme
        {
            get { return themeVar; }
            set { themeVar = value; regKey.SetValue("theme", themeVar.ToString(), RegistryValueKind.String); }
        }

        public Primary colorSchemePrimary
        {
            get { return colorSchemePrimaryVar; }
            set { colorSchemePrimaryVar = value; regKey.SetValue("colorSchemePrimary", colorSchemePrimaryVar.ToString(), RegistryValueKind.String); }
        }

        public Primary colorSchemeDarkPrimary
        {
            get { return colorSchemeDarkPrimaryVar; }
            set { colorSchemeDarkPrimaryVar = value; regKey.SetValue("colorSchemeDarkPrimary", colorSchemeDarkPrimaryVar.ToString(), RegistryValueKind.String); }
        }

        public Primary colorSchemeLightPrimary
        {
            get { return colorSchemeLightPrimaryVar; }
            set { colorSchemeLightPrimaryVar = value; regKey.SetValue("colorSchemeLightPrimary", colorSchemeLightPrimaryVar.ToString(), RegistryValueKind.String); }
        }

        public Accent colorSchemeAccent
        {
            get { return colorSchemeAccentPrimaryVar; }
            set { colorSchemeAccentPrimaryVar = value; regKey.SetValue("colorSchemeAccentPrimary", colorSchemeAccentPrimaryVar.ToString(), RegistryValueKind.String); }
        }

        public TextShade colorSchemeTextShade
        {
            get { return colorSchemeTextShadeVar; }
            set { colorSchemeTextShadeVar = value; regKey.SetValue("colorSchemeTextShade", colorSchemeTextShadeVar.ToString(), RegistryValueKind.String); }
        }

        public int themeIndex
        {
            get { return getIndexForTheme(themeVar);  }
            set { theme = getThemeForIndex(value); }
        }

        public int colorSchemeIndex
        {
            get { return colorSchemeIndexVar; }
            set
            {
                var colorScheme = getColorSchemeForIndex(value);
                colorSchemePrimary = colorScheme.primary;
                colorSchemeDarkPrimary = colorScheme.darkPrimary;
                colorSchemeLightPrimary = colorScheme.lightPrimary;
                colorSchemeAccent = colorScheme.accent;
                colorSchemeTextShade = colorScheme.textShade;
                colorSchemeIndexVar = value;
                regKey.SetValue("colorSchemeIndex", Convert.ToString(colorSchemeIndexVar), RegistryValueKind.String);
            }
        }

        public bool hideOnStartup
        {
            get { return hideOnStartupVar; }
            set { hideOnStartupVar = value; regKey.SetValue("hideOnStartup", Convert2.boolToString(hideOnStartupVar), RegistryValueKind.String); }
        }

        private int getIndexForColorScheme(ColorScheme colorScheme)
        {
            ColorScheme orange = new ColorScheme(Primary.Orange800, Primary.Orange500, Primary.Orange900, Accent.Yellow200, TextShade.WHITE);
            ColorScheme blueGray = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ColorScheme blue = new ColorScheme(Primary.Blue800, Primary.Blue500, Primary.Blue900, Accent.Purple200, TextShade.WHITE);
            ColorScheme green = new ColorScheme(Primary.Green800, Primary.Green500, Primary.Green900, Accent.Yellow200, TextShade.WHITE);
            ColorScheme red = new ColorScheme(Primary.Red800, Primary.Red500, Primary.Red900, Accent.Orange200, TextShade.WHITE);

            if (colorScheme.Equals(orange)) return 0;
            else if (colorScheme.Equals(blueGray)) return 1;
            else if (colorScheme.Equals(blue)) return 2;
            else if (colorScheme.Equals(green)) return 3;
            else if (colorScheme.Equals(red)) return 4;
            return 0;
        }

        private ColorSchemeValues getColorSchemeForIndex(int index)
        {
            ColorSchemeValues orange = new ColorSchemeValues(Primary.Orange800, Primary.Orange500, Primary.Orange900, Accent.Yellow200, TextShade.WHITE);
            ColorSchemeValues blueGray = new ColorSchemeValues(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ColorSchemeValues blue = new ColorSchemeValues(Primary.Blue800, Primary.Blue500, Primary.Blue900, Accent.Purple200, TextShade.WHITE);
            ColorSchemeValues green = new ColorSchemeValues(Primary.Green800, Primary.Green500, Primary.Green900, Accent.Yellow200, TextShade.WHITE);
            ColorSchemeValues red = new ColorSchemeValues(Primary.Red800, Primary.Red500, Primary.Red900, Accent.Orange200, TextShade.WHITE);

            switch (index)
            {
                case 0: return orange;
                case 1: return blueGray;
                case 2: return blue;
                case 3: return green;
                case 4: return red;
            }
            return orange;
        }

        private int getIndexForTheme(MaterialSkinManager.Themes theme)
        {
            switch (theme)
            {
                case MaterialSkinManager.Themes.LIGHT: return 0;
                case MaterialSkinManager.Themes.DARK: return 1;
            }
            return 0;
        }

        private MaterialSkinManager.Themes getThemeForIndex(int index)
        {
            switch (index)
            {
                case 0: return MaterialSkinManager.Themes.LIGHT;
                case 1: return MaterialSkinManager.Themes.DARK;
            }
            return MaterialSkinManager.Themes.LIGHT;
        }

        private void createAndSetKeyIfNotExists(RegistryKey key, string name)
        {
            if (key.GetValue(name) == null)
            {
                RegValue defaultValue = getDefaultValue(name);
                key.SetValue(name, defaultValue.value, defaultValue.kind);
            }
        }

        private RegistryKey createAndGetSubkey(RegistryKey key, string subkey)
        {
            if (key.OpenSubKey(subkey, true) == null)
            {
                key.CreateSubKey(subkey);
            }
            return key.OpenSubKey(subkey, true);
        }

        private RegValue getDefaultValue(string key)
        {
            switch (key)
            {
                case "ip": return new RegValue("", RegistryValueKind.String);
                case "theme": return new RegValue("LIGHT", RegistryValueKind.String);
                case "colorSchemePrimary": return new RegValue("Orange800", RegistryValueKind.String);
                case "colorSchemeLightPrimary": return new RegValue("Orange900", RegistryValueKind.String);
                case "colorSchemeDarkPrimary": return new RegValue("Orange500", RegistryValueKind.String);
                case "colorSchemeAccentPrimary": return new RegValue("Yellow200", RegistryValueKind.String);
                case "colorSchemeTextShade": return new RegValue("WHITE", RegistryValueKind.String);
                case "colorSchemeIndex": return new RegValue("0", RegistryValueKind.String);
                case "hideOnStartup": return new RegValue("0", RegistryValueKind.String);
            }
            return new RegValue("0", RegistryValueKind.String);
        }
    }

    class RegValue
    {
        public string value;
        public RegistryValueKind kind;

        public RegValue(string value, RegistryValueKind kind)
        {
            this.value = value;
            this.kind = kind;
        }
    }

    class ColorSchemeValues
    {
        public Primary primary;
        public Primary darkPrimary;
        public Primary lightPrimary;
        public Accent accent;
        public TextShade textShade;

        public ColorSchemeValues(Primary primary, Primary darkPrimary, Primary lightPrimary, Accent accent, TextShade textShade)
        {
            this.primary = primary;
            this.darkPrimary = darkPrimary;
            this.lightPrimary = lightPrimary;
            this.accent = accent;
            this.textShade = textShade;
        }
    }

    class Convert2
    {
        public static string boolToString(bool value)
        {
            if (value)
            {
                return "1";
            }
            return "0";
        }

        public static bool stringToBool(string value)
        {
            return (value == "1" || value == "true");
        }
    }
}
