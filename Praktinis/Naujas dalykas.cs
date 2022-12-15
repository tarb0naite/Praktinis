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
    public partial class Naujas_dalykas : Form
    {
        private readonly Dalyku_kontrole _parent;
        public string id, pavadinimas;

        public Naujas_dalykas(Dalyku_kontrole parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            Itraukti.Text = "Atnaujinti";
            Pavadinimas.Text = pavadinimas;
        }

        public void Clear()
        {
            Pavadinimas.Text = string.Empty;
        }

        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            if (Pavadinimas.Text.Trim().Length < 3)
            {
                MessageBox.Show("Pavadinimas netinkamas");
                return;
            }

            if (Itraukti.Text == "Įtraukti")
            {
                Subject sbj = new Subject(Pavadinimas.Text.Trim());
                DbSubject.AddSub(sbj);
                Clear();
            }

            if (Itraukti.Text == "Atnaujinti")
            {
                Subject sbj = new Subject(Pavadinimas.Text.Trim());
                DbSubject.UpdateSub(sbj, id);
            }
            _parent.Display();
        }


    }
}
