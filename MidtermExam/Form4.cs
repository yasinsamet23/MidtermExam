using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void UpdateColor()
        {
            int red = trackBarRed.Value;
            label1.Text = red.ToString();
            int green = vScrollBarGreen.Value;
            label3.Text=green.ToString();
            int blue =hScrollBarBlue.Value;
            label2.Text=blue.ToString();
            lblColor.BackColor = Color.FromArgb(red, green, blue);
        }
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void vScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
