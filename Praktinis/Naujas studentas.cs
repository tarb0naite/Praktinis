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
    public partial class Naujas_studentas : Form
    {
        private readonly Studentų_kontrolė _parent;
       public string id, vardas, pavarde;
        public Naujas_studentas(Studentų_kontrolė parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            Itraukti.Text = "Atnaujinti";
            txtVardas.Text = vardas;
            txtPavarde.Text = pavarde;
        }

        public void Clear()
        {
            txtVardas.Text = txtPavarde.Text = string.Empty;
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            if(txtVardas.Text.Trim().Length < 3)
            {
                MessageBox.Show("Studento vardas netinkamas");
                return;
            }
            if (txtPavarde.Text.Trim().Length < 1)
            {
                MessageBox.Show("Studento pavarde netinkama");
                return;
            }
            if(Itraukti.Text == "Įtraukti")
            {
                Student std = new Student(txtVardas.Text.Trim(), txtPavarde.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            
            if (Itraukti.Text == "Atnaujinti")
            {
                Student std = new Student(txtVardas.Text.Trim(), txtPavarde.Text.Trim());
                DbStudent.UpdateStudent(std, id);
            }
            _parent.Display();

        }


        private void Atšaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
