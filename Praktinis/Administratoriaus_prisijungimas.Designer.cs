
namespace Praktinis2
{
    partial class Administratoriaus_prisijungimas
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
            this.Prisijungti = new System.Windows.Forms.Button();
            this.Prisijunimo_vardas = new System.Windows.Forms.Label();
            this.Slaptažodis = new System.Windows.Forms.Label();
            this.Prisijungimo_var = new System.Windows.Forms.TextBox();
            this.Slap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(39, 370);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(134, 48);
            this.Atšaukti.TabIndex = 0;
            this.Atšaukti.Text = "Atšaukti";
            this.Atšaukti.UseVisualStyleBackColor = false;
            this.Atšaukti.Click += new System.EventHandler(this.Atšaukti_Click);
            // 
            // Prisijungti
            // 
            this.Prisijungti.BackColor = System.Drawing.Color.DarkKhaki;
            this.Prisijungti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prisijungti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Prisijungti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisijungti.Location = new System.Drawing.Point(213, 370);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(134, 48);
            this.Prisijungti.TabIndex = 0;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // Prisijunimo_vardas
            // 
            this.Prisijunimo_vardas.AutoSize = true;
            this.Prisijunimo_vardas.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisijunimo_vardas.Location = new System.Drawing.Point(47, 57);
            this.Prisijunimo_vardas.Name = "Prisijunimo_vardas";
            this.Prisijunimo_vardas.Size = new System.Drawing.Size(239, 30);
            this.Prisijunimo_vardas.TabIndex = 1;
            this.Prisijunimo_vardas.Text = "Prisijunimo vardas:";
            // 
            // Slaptažodis
            // 
            this.Slaptažodis.AutoSize = true;
            this.Slaptažodis.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slaptažodis.Location = new System.Drawing.Point(131, 200);
            this.Slaptažodis.Name = "Slaptažodis";
            this.Slaptažodis.Size = new System.Drawing.Size(155, 30);
            this.Slaptažodis.TabIndex = 1;
            this.Slaptažodis.Text = "Slaptažodis:";
            // 
            // Prisijungimo_var
            // 
            this.Prisijungimo_var.Location = new System.Drawing.Point(46, 108);
            this.Prisijungimo_var.Name = "Prisijungimo_var";
            this.Prisijungimo_var.Size = new System.Drawing.Size(267, 22);
            this.Prisijungimo_var.TabIndex = 2;
            // 
            // Slap
            // 
            this.Slap.Location = new System.Drawing.Point(46, 252);
            this.Slap.Name = "Slap";
            this.Slap.PasswordChar = '*';
            this.Slap.Size = new System.Drawing.Size(267, 22);
            this.Slap.TabIndex = 2;
            // 
            // Administratoriaus_prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.Slap);
            this.Controls.Add(this.Prisijungimo_var);
            this.Controls.Add(this.Slaptažodis);
            this.Controls.Add(this.Prisijunimo_vardas);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.Atšaukti);
            this.Name = "Administratoriaus_prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administratoriaus_prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.Label Prisijunimo_vardas;
        private System.Windows.Forms.Label Slaptažodis;
        private System.Windows.Forms.TextBox Prisijungimo_var;
        private System.Windows.Forms.TextBox Slap;
    }
}