using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWinningApp
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayer1.Text != String.Empty && txtPlayer2.Text != String.Empty)
            {
                Frm_Game formGame = new Frm_Game();
                formGame.setNamePlayer1(txtPlayer1.Text);
                formGame.setNamePlayer2(txtPlayer2.Text);
                formGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter name Player one and two then Start Game ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
