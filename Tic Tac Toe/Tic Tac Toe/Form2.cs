using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 204, 102);
            btnEasy.BackColor = Color.FromArgb(197, 112, 2);
            btnNormal.BackColor = Color.FromArgb(197, 112, 2);
            btnHard.BackColor = Color.FromArgb(197, 112, 2);


        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Easy newForm = new Easy();
            newForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Martin Grahovski ,Radostina Ranchova, Radislaw Iochev", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Normal newForm = new Normal();
            newForm.Show();
            this.Hide();
        }
    }
}
