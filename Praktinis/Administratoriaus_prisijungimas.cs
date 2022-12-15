using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2
{
    public partial class Administratoriaus_prisijungimas : Form
    {
        Administratorius admin = new Administratorius();
        public Administratoriaus_prisijungimas()
        {
            InitializeComponent();
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            log();
        }

        public void log()
        {
            string vardas = Prisijungimo_var.Text;
            string pavarde = Slap.Text;

            if (vardas == "admin" && pavarde == "admin123")
            {
                admin.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Prisijungimo vardas ar slaptažodis neteisingi");
            }
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
