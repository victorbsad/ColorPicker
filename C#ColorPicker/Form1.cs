using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap) pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lblSmallScreen.BackColor = clr;
            lblRgbValues.Text = $"R: {clr.R}, G: {clr.G}, B: {clr.B}";
            lblHexaValues.Text = $"#{clr.R:X2}{clr.G:X2}{clr.B:X2}";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap) pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            tbxRedValue.Text = clr.R.ToString();
            tbxGreenValue.Text = clr.G.ToString();
            tbxBlueValue.Text = clr.B.ToString();
            pnlSelectorScreen.BackColor = clr;
            tbxHexaValue.Text = $"#{clr.R:X2}{clr.G:X2}{clr.B:X2}";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
