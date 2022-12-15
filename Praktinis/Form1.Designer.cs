
namespace Praktinis2
{
    partial class Form1
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
            this.Administratorius = new System.Windows.Forms.Button();
            this.Dėstytojas = new System.Windows.Forms.Button();
            this.Studentas = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Dienynas = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administratorius
            // 
            this.Administratorius.BackColor = System.Drawing.Color.Sienna;
            this.Administratorius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Administratorius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administratorius.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Administratorius.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administratorius.ForeColor = System.Drawing.Color.Black;
            this.Administratorius.Location = new System.Drawing.Point(40, 137);
            this.Administratorius.Name = "Administratorius";
            this.Administratorius.Size = new System.Drawing.Size(216, 88);
            this.Administratorius.TabIndex = 0;
            this.Administratorius.Text = "Administratorius";
            this.Administratorius.UseVisualStyleBackColor = false;
            this.Administratorius.Click += new System.EventHandler(this.Administratorius_Click);
            // 
            // Dėstytojas
            // 
            this.Dėstytojas.BackColor = System.Drawing.Color.Sienna;
            this.Dėstytojas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dėstytojas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dėstytojas.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dėstytojas.Location = new System.Drawing.Point(503, 341);
            this.Dėstytojas.Name = "Dėstytojas";
            this.Dėstytojas.Size = new System.Drawing.Size(200, 86);
            this.Dėstytojas.TabIndex = 0;
            this.Dėstytojas.Text = "Dėstytojas";
            this.Dėstytojas.UseVisualStyleBackColor = false;
            this.Dėstytojas.Click += new System.EventHandler(this.Dėstytojas_Click);
            // 
            // Studentas
            // 
            this.Studentas.BackColor = System.Drawing.Color.Sienna;
            this.Studentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Studentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Studentas.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentas.Location = new System.Drawing.Point(272, 240);
            this.Studentas.Name = "Studentas";
            this.Studentas.Size = new System.Drawing.Size(200, 86);
            this.Studentas.TabIndex = 0;
            this.Studentas.Text = "Studentas";
            this.Studentas.UseVisualStyleBackColor = false;
            this.Studentas.Click += new System.EventHandler(this.Studentas_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Peru;
            this.panel.Controls.Add(this.Dienynas);
            this.panel.ForeColor = System.Drawing.Color.Sienna;
            this.panel.Location = new System.Drawing.Point(1, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 93);
            this.panel.TabIndex = 1;
            // 
            // Dienynas
            // 
            this.Dienynas.AutoSize = true;
            this.Dienynas.Font = new System.Drawing.Font("Marcellus SC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dienynas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Dienynas.Location = new System.Drawing.Point(33, 33);
            this.Dienynas.Name = "Dienynas";
            this.Dienynas.Size = new System.Drawing.Size(136, 35);
            this.Dienynas.TabIndex = 0;
            this.Dienynas.Text = "Dienynas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dėstytojas);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Administratorius);
            this.Controls.Add(this.Studentas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Administratorius;
        private System.Windows.Forms.Button Dėstytojas;
        private System.Windows.Forms.Button Studentas;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Dienynas;
    }
}

