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
    public partial class Administratorius : Form
    {
        public Administratorius()
        {
            InitializeComponent();
        }

        private void Studentu_kontrole_Click(object sender, EventArgs e)
        {
            Studentų_kontrolė stud = new Studentų_kontrolė();
            stud.ShowDialog();
        }

        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destytoju_kontrole_Click(object sender, EventArgs e)
        {
            Dėstytojų_kontrolė prof = new Dėstytojų_kontrolė();
            prof.ShowDialog();
        }

       

        private void Dalyku_kontrole_Click(object sender, EventArgs e)
        {
            Dalyku_kontrole sub = new Dalyku_kontrole();
            sub.ShowDialog();
        }

        private void Grupiu_kontrole_Click(object sender, EventArgs e)
        {
            Grupiu_kontrole idk = new Grupiu_kontrole();
            idk.ShowDialog();
        }

        private void Bendras_Click(object sender, EventArgs e)
        {
            Stud_Ir_Dal_Prie_Grupes_Kontrole bendras = new Stud_Ir_Dal_Prie_Grupes_Kontrole();
            bendras.ShowDialog();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Priskirimas idk = new Priskirimas();
            idk.ShowDialog();
        }
       */
    }
}
