using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsProject
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        public CustomTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public bool IsDec { get; set; } = true;

        public int Value => this.Text.Length > 0 ? (IsDec ? int.Parse(this.Text) : Convert.ToInt32(this.Text, 16)) : 0;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
            if (IsDec)
            {
                if (Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar)) e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar) || (e.KeyChar >= 97 && e.KeyChar <= 102)) e.Handled = false;
            }
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                if (IsDec)
                {
                    if (int.Parse(this.Text) > 255) this.Text = "255";
                }
                else
                {
                    if (this.Text.Length > 2) this.Text = "ff";
                }
            }
            catch (Exception)
            {
                if (this.Text.Length != 0) this.Text = "0";
            }

            base.OnTextChanged(e);
        }
    }
}
