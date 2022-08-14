using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tic_Tac_Toe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool flag = true;
        int count = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
          
           this.BackColor = Color.FromArgb(255, 204, 102);
         
        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Martin Grahovski", "About");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (flag)
            { b.Text = "X"; }
            else
                b.Text = "O";
            flag = !flag;
            b.Enabled = false;
            count++;
            checkForWinner();

        }
        private void checkForWinner()
        {

            bool pobeditel = false;

            //horizontalno
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            { pobeditel = true; }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            { pobeditel = true; }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            { pobeditel = true; }

            //vertikalno
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            { pobeditel = true; }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            { pobeditel = true; }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            { pobeditel = true; }

            //diagonalno
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            { pobeditel = true; }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            { pobeditel = true; }

            if (pobeditel)
            {

                string winner = "";
                if (flag)
                {
                    winner = "O";
                    lblO.Text = (Int32.Parse(lblO.Text) + 1).ToString();
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                else
                {
                    winner = "X";
                    lblX.Text = (Int32.Parse(lblX.Text) + 1).ToString();
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                MessageBox.Show(winner + "  Wins!", "Winner!");
            }
            else
            {
                if (count == 9)
                {
                    lblD.Text = (Int32.Parse(lblD.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Draw!");

                }
            }
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            flag = true;
            count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }


            lblX.Text = "0";
            lblD.Text = "0";
            lblO.Text = "0";
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            count = 0;
            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            
            
            lblX.Text = "0";
            lblD.Text = "0";
            lblO.Text = "0";
        }
       
        private void lblReset_Click(object sender, EventArgs e)
        {
            flag = true;
            count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }

                
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void lblD_Click(object sender, EventArgs e)
        {

        }

        private void restToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }


            }
        }
    }
}




