namespace Mission2
{
    partial class Secteurs_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Retour = new System.Windows.Forms.Button();
            this.lb_Secteurs = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.lbSecteurs = new System.Windows.Forms.ListBox();
            this.SelectionnerSecteur = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Retour);
            this.panel1.Controls.Add(this.lb_Secteurs);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 66);
            this.panel1.TabIndex = 0;
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.LightGreen;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retour.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ForeColor = System.Drawing.Color.Teal;
            this.Retour.Location = new System.Drawing.Point(12, 6);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(151, 53);
            this.Retour.TabIndex = 7;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // lb_Secteurs
            // 
            this.lb_Secteurs.AutoSize = true;
            this.lb_Secteurs.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_Secteurs.ForeColor = System.Drawing.Color.White;
            this.lb_Secteurs.Location = new System.Drawing.Point(238, 9);
            this.lb_Secteurs.Name = "lb_Secteurs";
            this.lb_Secteurs.Size = new System.Drawing.Size(210, 38);
            this.lb_Secteurs.TabIndex = 7;
            this.lb_Secteurs.Text = "SECTEURS";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(664, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 66);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lbSecteurs
            // 
            this.lbSecteurs.BackColor = System.Drawing.Color.White;
            this.lbSecteurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSecteurs.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbSecteurs.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecteurs.FormattingEnabled = true;
            this.lbSecteurs.ItemHeight = 20;
            this.lbSecteurs.Location = new System.Drawing.Point(30, 82);
            this.lbSecteurs.Name = "lbSecteurs";
            this.lbSecteurs.Size = new System.Drawing.Size(724, 320);
            this.lbSecteurs.TabIndex = 1;
            // 
            // SelectionnerSecteur
            // 
            this.SelectionnerSecteur.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SelectionnerSecteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectionnerSecteur.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionnerSecteur.ForeColor = System.Drawing.Color.White;
            this.SelectionnerSecteur.Location = new System.Drawing.Point(200, 419);
            this.SelectionnerSecteur.Name = "SelectionnerSecteur";
            this.SelectionnerSecteur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectionnerSecteur.Size = new System.Drawing.Size(327, 45);
            this.SelectionnerSecteur.TabIndex = 2;
            this.SelectionnerSecteur.Text = "Selectionner";
            this.SelectionnerSecteur.UseVisualStyleBackColor = false;
            this.SelectionnerSecteur.Click += new System.EventHandler(this.SelectionnerSecteur_Click);
            // 
            // Secteurs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(785, 485);
            this.Controls.Add(this.SelectionnerSecteur);
            this.Controls.Add(this.lbSecteurs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Secteurs_Form";
            this.Text = "Accueil_Form";
            this.Load += new System.EventHandler(this.Secteurs_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbSecteurs;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lb_Secteurs;
        private System.Windows.Forms.Button SelectionnerSecteur;
        private System.Windows.Forms.Button Retour;
    }
}