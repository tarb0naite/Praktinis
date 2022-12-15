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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Administratorius_Click(object sender, EventArgs e)
        {
            Administratoriaus_prisijungimas admin_log = new Administratoriaus_prisijungimas();
            admin_log.ShowDialog();
            
            
        }

        private void Studentas_Click(object sender, EventArgs e)
        {
            Studento_prisijungimas stud_log = new Studento_prisijungimas();
            stud_log.ShowDialog();
        }

        private void Dėstytojas_Click(object sender, EventArgs e)
        {
            Destytojo_prisijungimas prof_log = new Destytojo_prisijungimas();
            prof_log.ShowDialog();
            Destytojas prof = new Destytojas();
            
        }
    }
}
