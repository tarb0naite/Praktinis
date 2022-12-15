
namespace Praktinis2
{
    partial class Studento_prisijungimas
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
            this.Atšaukti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Prisijungimo_vardas = new System.Windows.Forms.Label();
            this.Slaptažodis = new System.Windows.Forms.Label();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.txtPavarde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(49, 421);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(131, 57);
            this.Atšaukti.TabIndex = 0;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prisijungimo_vardas
            // 
            this.Prisijungimo_vardas.AutoSize = true;
            this.Prisijungimo_vardas.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisijungimo_vardas.Location = new System.Drawing.Point(82, 71);
            this.Prisijungimo_vardas.Name = "Prisijungimo_vardas";
            this.Prisijungimo_vardas.Size = new System.Drawing.Size(254, 30);
            this.Prisijungimo_vardas.TabIndex = 1;
            this.Prisijungimo_vardas.Text = "Prisijungimo vardas:";
            // 
            // Slaptažodis
            // 
            this.Slaptažodis.AutoSize = true;
            this.Slaptažodis.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slaptažodis.Location = new System.Drawing.Point(191, 242);
            this.Slaptažodis.Name = "Slaptažodis";
            this.Slaptažodis.Size = new System.Drawing.Size(155, 30);
            this.Slaptažodis.TabIndex = 1;
            this.Slaptažodis.Text = "Slaptažodis:";
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(84, 123);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(262, 22);
            this.txtVardas.TabIndex = 2;
            // 
            // txtPavarde
            // 
            this.txtPavarde.Location = new System.Drawing.Point(84, 293);
            this.txtPavarde.Name = "txtPavarde";
            this.txtPavarde.PasswordChar = '*';
            this.txtPavarde.Size = new System.Drawing.Size(262, 22);
            this.txtPavarde.TabIndex = 2;
            // 
            // Studento_prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(426, 512);
            this.Controls.Add(this.txtPavarde);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.Slaptažodis);
            this.Controls.Add(this.Prisijungimo_vardas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Atšaukti);
            this.Name = "Studento_prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studento_prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Prisijungimo_vardas;
        private System.Windows.Forms.Label Slaptažodis;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.TextBox txtPavarde;
    }
}