
namespace Praktinis2
{
    partial class Naujas_destytojas
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
            this.Atgal = new System.Windows.Forms.Button();
            this.Itraukti = new System.Windows.Forms.Button();
            this.naujas_var = new System.Windows.Forms.Label();
            this.Vardas = new System.Windows.Forms.TextBox();
            this.Nauja_pav = new System.Windows.Forms.Label();
            this.Pavarde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Atgal
            // 
            this.Atgal.BackColor = System.Drawing.Color.Tomato;
            this.Atgal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atgal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atgal.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atgal.Location = new System.Drawing.Point(60, 463);
            this.Atgal.Name = "Atgal";
            this.Atgal.Size = new System.Drawing.Size(162, 42);
            this.Atgal.TabIndex = 0;
            this.Atgal.Text = "Atgal";
            this.Atgal.UseVisualStyleBackColor = false;
            this.Atgal.Click += new System.EventHandler(this.Atgal_Click);
            // 
            // Itraukti
            // 
            this.Itraukti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Itraukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Itraukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itraukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itraukti.Location = new System.Drawing.Point(260, 463);
            this.Itraukti.Name = "Itraukti";
            this.Itraukti.Size = new System.Drawing.Size(162, 42);
            this.Itraukti.TabIndex = 0;
            this.Itraukti.Text = "Įtraukti";
            this.Itraukti.UseVisualStyleBackColor = false;
            this.Itraukti.Click += new System.EventHandler(this.Itraukti_Click);
            // 
            // naujas_var
            // 
            this.naujas_var.AutoSize = true;
            this.naujas_var.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naujas_var.Location = new System.Drawing.Point(33, 43);
            this.naujas_var.Name = "naujas_var";
            this.naujas_var.Size = new System.Drawing.Size(224, 30);
            this.naujas_var.TabIndex = 1;
            this.naujas_var.Text = "Dėstytojo vardas:";
            // 
            // Vardas
            // 
            this.Vardas.Location = new System.Drawing.Point(43, 96);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(325, 22);
            this.Vardas.TabIndex = 2;
            // 
            // Nauja_pav
            // 
            this.Nauja_pav.AutoSize = true;
            this.Nauja_pav.BackColor = System.Drawing.Color.Bisque;
            this.Nauja_pav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nauja_pav.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nauja_pav.Location = new System.Drawing.Point(38, 238);
            this.Nauja_pav.Name = "Nauja_pav";
            this.Nauja_pav.Size = new System.Drawing.Size(237, 30);
            this.Nauja_pav.TabIndex = 1;
            this.Nauja_pav.Text = "Dėstytojo pavarde:";
            this.Nauja_pav.Click += new System.EventHandler(this.Nauja_pav_Click);
            // 
            // Pavarde
            // 
            this.Pavarde.Location = new System.Drawing.Point(38, 297);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(330, 22);
            this.Pavarde.TabIndex = 2;
            this.Pavarde.TextChanged += new System.EventHandler(this.Pavarde_TextChanged);
            // 
            // Naujas_destytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(505, 530);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.Nauja_pav);
            this.Controls.Add(this.naujas_var);
            this.Controls.Add(this.Itraukti);
            this.Controls.Add(this.Atgal);
            this.Name = "Naujas_destytojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas_destytojas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atgal;
        private System.Windows.Forms.Button Itraukti;
        private System.Windows.Forms.Label naujas_var;
        private System.Windows.Forms.TextBox Vardas;
        private System.Windows.Forms.Label Nauja_pav;
        private System.Windows.Forms.TextBox Pavarde;
    }
}