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
    public partial class Dėstytojų_kontrolė : Form
        
    {
        Naujas_destytojas new_prof;
        public Dėstytojų_kontrolė()
        {
            InitializeComponent();
            new_prof = new Naujas_destytojas(this);
        }
        

        public void Display()
        {
            DbProf.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM prof", dataGridView);
        }

        private void Itraukti_nauja_Click(object sender, EventArgs e)
        {
            //Naujas_studentas new_stud = new Naujas_studentas(this);
            new_prof.Clear();
            new_prof.ShowDialog();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            DbProf.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM prof WHERE Vardas LIKE '%" + Search.Text + "%'", dataGridView);
        }

       

       

        private void Atgal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void naujas_dest_Click(object sender, EventArgs e)
        {
            Naujas_destytojas new_prof = new Naujas_destytojas(this);
            new_prof.ShowDialog();
        }

       

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //editinimas
            {
                new_prof.Clear();
                new_prof.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                new_prof.vardas = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                //new_stud.pavarde = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                new_prof.UpdateInfo();
                new_prof.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 1) //trinimas
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti destytoja?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbProf.DeleteProf(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dėstytojų_kontrolė_Load(object sender, EventArgs e)
        {

        }

        private void Dėstytojų_kontrolė_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Destytojo_mokomas_dalykas prof = new Destytojo_mokomas_dalykas();
            prof.ShowDialog();
        }
    }
}
