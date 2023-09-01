#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
#endregion
namespace astronomy_calculator_client
{
    public partial class Astronomy_calculator_client : Form
    {
        #region Initialisation
        public Astronomy_calculator_client()
        {
            InitializeComponent();
            ChangeThemeLightDark();
        }
        #endregion
        #region Add new item
        // Add Button.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Connect to server.
            string address = "net.pipe://localhost/pipe";
            NetNamedPipeBinding binding =
                new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel =
                ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            // Add to listview.
            ListViewItem lvi = new ListViewItem(textBoxNameOfBody.Text);
            lvi.SubItems.Add(ProcessStarVelocity(textBoxObservedWavelength, textBoxRestWavelength, channel.StarVelocity));
            lvi.SubItems.Add(ProcessStarDistance(textBoxParallaxAngle, channel.StarDistance));
            lvi.SubItems.Add(ProcessTemperatureConversion(textBoxCelsius, channel.TemperatureConversion));
            lvi.SubItems.Add(ProcessBlackholeEventHorizon(textBoxMassBase, textBoxMassExponent, channel.BlackholeEventHorizon));
            listView.Items.Add(lvi);

            // Clear textboxes.
            textBoxNameOfBody.Clear();
            textBoxObservedWavelength.Clear();
            textBoxRestWavelength.Clear();
            textBoxParallaxAngle.Clear();
            textBoxCelsius.Clear();
            textBoxMassBase.Clear();
            textBoxMassExponent.Clear();
        }
        #endregion
        #region Process DLLs
        // Star Distance.
        private string ProcessStarDistance(System.Windows.Forms.TextBox textBoxParallaxAngle, Func<double, double> DLL)
        {
            // If the user enters no value print blank.
            if (textBoxParallaxAngle.Text == "")
                return "";
            try
            {
                // Parse inputs to double.
                double input = double.Parse(textBoxParallaxAngle.Text);
                // Catch / 0 errors.
                if (input == 0)
                    return "Error: Division by zero";
                // Pass to DLL.
                double output = DLL(input);
                // Format DLL output.
                //return output.ToString() + " pc";
                return string.Format("{0:0.##}", output) + " pc";
            }
            catch { return "Error: Check connection"; }
        }
        // Temperature Conversion.
        private string ProcessTemperatureConversion(System.Windows.Forms.TextBox textBoxCelsius, Func<double, double> DLL)
        {
            // If the user enters no value print blank.
            if (textBoxCelsius.Text == "")
                return "";
            try
            {
                // Parse input to double.
                double input = double.Parse(textBoxCelsius.Text);
                // Catch below absoute zero.
                if (input < -273.15)
                    return "Error: Below absoute zero";
                // Pass to DLL.
                double output = DLL(input);
                // Format DLL output.
                return output.ToString() + " °K";
            }
            catch { return "Error: Check connection"; }
        }
        // Star Velocity.
        private string ProcessStarVelocity(System.Windows.Forms.TextBox textBoxObservedWavelength, System.Windows.Forms.TextBox textBoxRestWavelength, Func<double, double, double> DLL)
        {
            // If the user enters no value print blank.
            if (textBoxObservedWavelength.Text == "" || textBoxRestWavelength.Text == "")
                return "";
            try
            {
                // Parse inputs to double.
                double observedWavelengthInNanoMetres = double.Parse(textBoxObservedWavelength.Text);
                double restWavelengthInNanoMetres = double.Parse(textBoxRestWavelength.Text); 
                // Catch / 0 errors.
                if (restWavelengthInNanoMetres == 0)
                    return "Error: Division by zero";
                // Pass to DLL.
                double output = DLL(observedWavelengthInNanoMetres, restWavelengthInNanoMetres);
                // Format DLL output.
                return string.Format("{0:0.##E+00}", output) + " m/s";
            }
            catch { return "Error: Check connection"; }
        }
        // Blackhole Event Horizon.
        private string ProcessBlackholeEventHorizon(System.Windows.Forms.TextBox textBoxMassBase, System.Windows.Forms.TextBox textBoxMassExponent, Func<double, double> DLL)
        {
            // If the user enters no value print blank.
            if (textBoxMassBase.Text == "" || textBoxMassExponent.Text == "")
                return "";
            try
            {
                // Parse inputs to double.
                double massBase = double.Parse(textBoxMassBase.Text);
                double massExponent = double.Parse(textBoxMassExponent.Text);
                // Combine inputs to a single large number.
                double blackHoleMassInKilograms = massBase * Math.Pow(10, massExponent);
                // Pass to DLL.
                double output = DLL(blackHoleMassInKilograms);
                // Format DLL output.
                return string.Format("{0:0.##E+00}", output) + " m";
            }
            catch { return "Error: Check connection"; }
        }
        #endregion
        #region Keypress filtering
        // Logic.
        private void FilterKeypresses(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            // Blocks all key entries except:
            // "\d" numeric characters
            // "."  decimal point
            // "\b" backspace and delete
            // "-"  negative symbol
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d.\b-]"))
                e.Handled = true;
            // Allow only one decimal point within the text box.
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
                e.Handled = true;
            // Restrict the use of the negative sign to the first index of the text box.
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
                e.Handled = true;
        }
        // Event handeling.
        private void textBoxCelsius_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxCelsius); }
        private void textBoxObservedWavelength_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxObservedWavelength); }
        private void textBoxRestWavelength_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxRestWavelength); }
        private void textBoxParallaxAngle_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxParallaxAngle); }
        private void textBoxMassBase_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxMassBase); }
        private void textBoxMassExponent_KeyPress(object sender, KeyPressEventArgs e)
        { FilterKeypresses(sender, e, textBoxMassExponent); }
        #endregion
        #region Language selection
        // Logic.
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }
        // Event handeling.
        private void toolStripMenuItemEnglish_Click(object sender, EventArgs e)
        { ChangeLanguage("English"); }
        private void toolStripMenuItemFrench_Click(object sender, EventArgs e)
        { ChangeLanguage("French"); }
        private void toolStripMenuItemGerman_Click(object sender, EventArgs e)
        { ChangeLanguage("German"); }
        #endregion
        #region Theme selection
        // Select custom background colour from a colour palette.
        private void toolStripMenuItemColour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                // Colour selected by the user.
                BackColor = colorDlg.Color;
                // Opposite colour of user selection.
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                Color oppositeColour = Color.FromArgb(r, g, b);
                // Group box text colour.
                foreach (var text in Controls.OfType<System.Windows.Forms.GroupBox>())
                    text.ForeColor = oppositeColour;
            }
        }
        // Light / dark mode.
        private void ChangeThemeLightDark()
        {
            // Light mode.
            if (BackColor != Color.White)
            {
                // Background.
                BackColor = Color.White;
                // Text.
                ForeColor = Color.Black;
                // Buttons.
                foreach (var button in Controls.OfType<System.Windows.Forms.Button>())
                {
                    button.BackColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.Gray;
                }
                // Labels.
                foreach (var label in Controls.OfType<Label>())
                    label.ForeColor = Color.Green;
                // Text boxes.
                foreach (var textBox in Controls.OfType<System.Windows.Forms.TextBox>())
                    textBox.ForeColor = Color.DarkOrchid;
                // Text within group boxes.
                foreach (var text in Controls.OfType<System.Windows.Forms.GroupBox>())
                    text.ForeColor = Color.Black;
                // Tool strip.
                foreach (var element in Controls.OfType<System.Windows.Forms.ToolStrip>())
                {
                    // Text.
                    element.ForeColor = Color.Black;
                    // Background.
                    element.BackColor = Color.WhiteSmoke;
                }
                // List view.
                foreach (var element in Controls.OfType<System.Windows.Forms.ListView>())
                {
                    // Text.
                    element.ForeColor = Color.Black;
                    // Background.
                    element.BackColor = Color.White;
                }
            }
            // Dark mode.
            else if (BackColor != Color.FromArgb(48, 10, 36))
            {
                // Background.
                BackColor = Color.FromArgb(94, 39, 80);
                // Text.
                ForeColor = Color.White;
                // Buttons.
                foreach (var button in Controls.OfType<System.Windows.Forms.Button>())
                {
                    // Main.
                    button.BackColor = Color.FromArgb(119, 33, 111);
                    button.FlatStyle = FlatStyle.Flat;
                    // Outline.
                    button.FlatAppearance.BorderColor = Color.White;
                }
                // Labels.
                foreach (var label in Controls.OfType<Label>())
                    label.ForeColor = Color.LemonChiffon;
                // Text boxes.
                foreach (var textBox in Controls.OfType<System.Windows.Forms.TextBox>())
                    textBox.ForeColor = Color.SeaGreen;
                // Group boxes.
                foreach (var text in Controls.OfType<System.Windows.Forms.GroupBox>())
                    text.ForeColor = Color.White;
                // Tool strip.
                foreach (var element in Controls.OfType<System.Windows.Forms.ToolStrip>())
                {
                    // Text.
                    element.ForeColor = Color.LightGray;
                    // Background.
                    element.BackColor = Color.FromArgb(119, 33, 111);
                }
                // List view.
                foreach (var element in Controls.OfType<System.Windows.Forms.ListView>())
                {
                    // Text.
                    element.ForeColor = Color.White;
                    // Background.
                    element.BackColor = Color.FromArgb(94, 39, 80);
                }
            }
        }
        // Button: Light / dark mode, Event handeling.
        private void toolStripMenuItemLightOrDark_Click(object sender, EventArgs e)
        {
            ChangeThemeLightDark();
        }
        #endregion
    }
}
