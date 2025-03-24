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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text=File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text |*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 File.WriteAllText(saveFileDialog1.FileName,txtEditor.Text);
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void toolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
