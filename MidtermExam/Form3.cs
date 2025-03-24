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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGrade.SelectedItem=="A")
            {
                MessageBox.Show("You selected Grade: A");
            }
            else if(cmbGrade.SelectedItem == "B")
            {
                MessageBox.Show("You selected Grade: B");
            }
            else if(cmbGrade.SelectedItem == "C")
            {
                MessageBox.Show("You selected Grade: C");
            }
            else if (cmbGrade.SelectedItem == "D")
            {
                MessageBox.Show("You selected Grade: D");
            }
            else if (cmbGrade.SelectedItem == "F")
            {
                MessageBox.Show("You selected Grade: F");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstboxTodo.Items.Add(txtEditor.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstboxTodo.Items.Remove(lstboxTodo.SelectedItem);
        }

        private void btnCleaAll_Click(object sender, EventArgs e)
        {
            lstboxTodo.Items.Clear();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
