using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlsProject
{
    public partial class Colour : UserControl
    {
        private bool IsDecimalInput { get; set; } = true;
        private bool isColorChanged = true; 

        public Color PanelColor { get => panel1.BackColor; set {;} }

        public Colour()
        {
            InitializeComponent();
            Dec.Checked = true;
            panel1.BackColor = Color.Black;
        }

        private void ChangeTextBoxes(bool radioButton)
        {
            try
            {
                if (!radioButton)
                {
                    Red.Text = Convert.ToString(int.Parse(Red.Text), 16);
                    Green.Text = Convert.ToString(int.Parse(Green.Text), 16);
                    Blue.Text = Convert.ToString(int.Parse(Blue.Text), 16);
                    isColorChanged = true;
                }
                else
                {
                    Red.Text = Convert.ToInt32(Red.Text, 16).ToString();
                    Green.Text = Convert.ToInt32(Green.Text, 16).ToString();
                    Blue.Text = Convert.ToInt32(Blue.Text, 16).ToString();
                    isColorChanged = true;
                }
            }
            catch (Exception) { }
        }

        private void Dec_CheckedChanged(object sender, EventArgs e)
        {
            isColorChanged = false;
            IsDecimalInput = Dec.Checked;
            Red.IsDec = IsDecimalInput;
            Green.IsDec = IsDecimalInput;
            Blue.IsDec = IsDecimalInput;
            ChangeTextBoxes(IsDecimalInput);
        }

        private void ParseColor()
        {
            panel1.BackColor = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
        }


        private void Red_TextChanged(object sender, EventArgs e)
        {
            if (isColorChanged) ParseColor();
        }

        private void Green_TextChanged(object sender, EventArgs e)
        {
            if (isColorChanged) ParseColor();
        }

        private void Blue_TextChanged(object sender, EventArgs e)
        {
            if (isColorChanged) ParseColor();
        }
    }
}
