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
    public partial class Naujas_destytojas : Form
    {
        private readonly Dėstytojų_kontrolė _parent;
        public string id, vardas, pavarde;
        public Naujas_destytojas(Dėstytojų_kontrolė parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            Itraukti.Text = "Atnaujinti";
            Vardas.Text = vardas;
            Pavarde.Text = pavarde;
        }

        public void Clear()
        {
            Vardas.Text = Pavarde.Text = string.Empty;
        }

       

        private void Pavarde_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nauja_pav_Click(object sender, EventArgs e)
        {

        }

        

        private void Atgal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            if (Vardas.Text.Trim().Length < 3)
            {
                MessageBox.Show("Destytojo vardas netinkamas");
                return;
            }
            if (Pavarde.Text.Trim().Length < 1)
            {
                MessageBox.Show("Destytojo pavarde netinkama");
                return;
            }
            if (Itraukti.Text == "Įtraukti")
            {
                Prof prf = new Prof(Vardas.Text.Trim(), Pavarde.Text.Trim());
                DbProf.AddProf(prf);
                Clear();
            }

            if (Itraukti.Text == "Atnaujinti")
            {
               Prof prf = new Prof(Vardas.Text.Trim(), Pavarde.Text.Trim());
                DbProf.UpdateProf(prf, id);
            }
            _parent.Display();

        }

    }
}

