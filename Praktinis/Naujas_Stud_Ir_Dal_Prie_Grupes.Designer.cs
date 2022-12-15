
namespace Praktinis2
{
    partial class Naujas_Stud_Ir_Dal_Prie_Grupes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Itraukti = new System.Windows.Forms.Button();
            this.Atšaukti = new System.Windows.Forms.Button();
            this.comboVardas = new System.Windows.Forms.ComboBox();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.comboGrupe = new System.Windows.Forms.ComboBox();
            this.txtGrupe = new System.Windows.Forms.TextBox();
            this.txtDalykas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Itraukti
            // 
            this.Itraukti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Itraukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti.Location = new System.Drawing.Point(417, 351);
            this.Itraukti.Name = "Itraukti";
            this.Itraukti.Size = new System.Drawing.Size(182, 54);
            this.Itraukti.TabIndex = 0;
            this.Itraukti.Text = "Įtraukti";
            this.Itraukti.UseVisualStyleBackColor = false;
            this.Itraukti.Click += new System.EventHandler(this.Itraukti_Click);
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(168, 351);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(182, 54);
            this.Atšaukti.TabIndex = 0;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // comboVardas
            // 
            this.comboVardas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboVardas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVardas.FormattingEnabled = true;
            this.comboVardas.Location = new System.Drawing.Point(320, 41);
            this.comboVardas.Name = "comboVardas";
            this.comboVardas.Size = new System.Drawing.Size(192, 24);
            this.comboVardas.TabIndex = 1;
            this.comboVardas.SelectedIndexChanged += new System.EventHandler(this.comboVardas_SelectedIndexChanged);
            // 
            // txtVardas
            // 
            this.txtVardas.BackColor = System.Drawing.Color.White;
            this.txtVardas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVardas.Location = new System.Drawing.Point(30, 278);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(221, 22);
            this.txtVardas.TabIndex = 2;
            // 
            // comboGrupe
            // 
            this.comboGrupe.FormattingEnabled = true;
            this.comboGrupe.Location = new System.Drawing.Point(320, 137);
            this.comboGrupe.Name = "comboGrupe";
            this.comboGrupe.Size = new System.Drawing.Size(200, 24);
            this.comboGrupe.TabIndex = 4;
            this.comboGrupe.SelectedIndexChanged += new System.EventHandler(this.comboGrupe_SelectedIndexChanged);
            // 
            // txtGrupe
            // 
            this.txtGrupe.BackColor = System.Drawing.Color.White;
            this.txtGrupe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupe.Location = new System.Drawing.Point(610, 278);
            this.txtGrupe.Name = "txtGrupe";
            this.txtGrupe.Size = new System.Drawing.Size(109, 22);
            this.txtGrupe.TabIndex = 5;
            this.txtGrupe.Visible = false;
            // 
            // txtDalykas
            // 
            this.txtDalykas.BackColor = System.Drawing.Color.White;
            this.txtDalykas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDalykas.Location = new System.Drawing.Point(343, 278);
            this.txtDalykas.Name = "txtDalykas";
            this.txtDalykas.Size = new System.Drawing.Size(169, 22);
            this.txtDalykas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parinkite studentą pagal vardą:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parinkite grupe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parinkto studento vardas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Priklausantis dalykas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Marcellus SC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parinkta grupė:";
            // 
            // Naujas_Stud_Ir_Dal_Prie_Grupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(938, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDalykas);
            this.Controls.Add(this.txtGrupe);
            this.Controls.Add(this.comboGrupe);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.comboVardas);
            this.Controls.Add(this.Atšaukti);
            this.Controls.Add(this.Itraukti);
            this.Name = "Naujas_Stud_Ir_Dal_Prie_Grupes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas_Stud_Ir_Dal_Prie_Grupes";
            this.Load += new System.EventHandler(this.Naujas_Stud_Ir_Dal_Prie_Grupes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Itraukti;
        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.ComboBox comboVardas;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.ComboBox comboGrupe;
        private System.Windows.Forms.TextBox txtGrupe;
        private System.Windows.Forms.TextBox txtDalykas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}