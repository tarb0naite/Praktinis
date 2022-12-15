
namespace Praktinis2
{
    partial class Destytojo_prisijungimas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prisijungimo_var = new System.Windows.Forms.TextBox();
            this.Prisijungio_slap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Atšaukti
            // 
            this.Atšaukti.BackColor = System.Drawing.Color.Tomato;
            this.Atšaukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atšaukti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atšaukti.Font = new System.Drawing.Font("Marcellus SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atšaukti.Location = new System.Drawing.Point(2, 379);
            this.Atšaukti.Name = "Atšaukti";
            this.Atšaukti.Size = new System.Drawing.Size(140, 48);
            this.Atšaukti.TabIndex = 3;
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
            this.Prisijungti.Location = new System.Drawing.Point(186, 379);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(140, 48);
            this.Prisijungti.TabIndex = 4;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisijungimo vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marcellus SC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slaptažodis:";
            // 
            // Prisijungimo_var
            // 
            this.Prisijungimo_var.Location = new System.Drawing.Point(31, 120);
            this.Prisijungimo_var.Name = "Prisijungimo_var";
            this.Prisijungimo_var.Size = new System.Drawing.Size(264, 22);
            this.Prisijungimo_var.TabIndex = 0;
            // 
            // Prisijungio_slap
            // 
            this.Prisijungio_slap.Location = new System.Drawing.Point(44, 239);
            this.Prisijungio_slap.Name = "Prisijungio_slap";
            this.Prisijungio_slap.PasswordChar = '*';
            this.Prisijungio_slap.Size = new System.Drawing.Size(251, 22);
            this.Prisijungio_slap.TabIndex = 1;
            // 
            // Destytojo_prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.Prisijungio_slap);
            this.Controls.Add(this.Prisijungimo_var);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.Atšaukti);
            this.Name = "Destytojo_prisijungimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojo_prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atšaukti;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prisijungimo_var;
        private System.Windows.Forms.TextBox Prisijungio_slap;
    }
}