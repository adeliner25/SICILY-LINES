using System;
using System.Collections.Generic;

namespace Mission2
{
    partial class Liaisons_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLiaisons = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Supprimer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Modifier = new System.Windows.Forms.Button();
            this.tb_modification_Duree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_portArrive = new System.Windows.Forms.ComboBox();
            this.cb_portDepart = new System.Windows.Forms.ComboBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.tb_ajouter_numLiaison = new System.Windows.Forms.TextBox();
            this.Ports = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.lb_ajouter_Duree = new System.Windows.Forms.Label();
            this.tb_ajouter_Duree = new System.Windows.Forms.TextBox();
            this.Retour = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.lb_numSecteur = new System.Windows.Forms.Label();
            this.lb_nombre_secteurs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLiaisons
            // 
            this.lbLiaisons.BackColor = System.Drawing.Color.White;
            this.lbLiaisons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLiaisons.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLiaisons.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLiaisons.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbLiaisons.FormattingEnabled = true;
            this.lbLiaisons.ItemHeight = 20;
            this.lbLiaisons.Location = new System.Drawing.Point(214, 102);
            this.lbLiaisons.Name = "lbLiaisons";
            this.lbLiaisons.Size = new System.Drawing.Size(563, 360);
            this.lbLiaisons.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.Supprimer);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Retour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 498);
            this.panel1.TabIndex = 2;
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Brown;
            this.Supprimer.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.White;
            this.Supprimer.Location = new System.Drawing.Point(24, 434);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(138, 52);
            this.Supprimer.TabIndex = 6;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.Modifier);
            this.panel4.Controls.Add(this.tb_modification_Duree);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 88);
            this.panel4.TabIndex = 17;
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Teal;
            this.Modifier.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(24, 12);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(132, 33);
            this.Modifier.TabIndex = 5;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // tb_modification_Duree
            // 
            this.tb_modification_Duree.Location = new System.Drawing.Point(74, 51);
            this.tb_modification_Duree.Name = "tb_modification_Duree";
            this.tb_modification_Duree.Size = new System.Drawing.Size(100, 22);
            this.tb_modification_Duree.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Durée :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cb_portArrive);
            this.panel3.Controls.Add(this.cb_portDepart);
            this.panel3.Controls.Add(this.Ajouter);
            this.panel3.Controls.Add(this.tb_ajouter_numLiaison);
            this.panel3.Controls.Add(this.Ports);
            this.panel3.Controls.Add(this.numero);
            this.panel3.Controls.Add(this.lb_ajouter_Duree);
            this.panel3.Controls.Add(this.tb_ajouter_Duree);
            this.panel3.Location = new System.Drawing.Point(6, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 262);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port d\'arrivée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port de départ";
            // 
            // cb_portArrive
            // 
            this.cb_portArrive.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_portArrive.FormattingEnabled = true;
            this.cb_portArrive.Location = new System.Drawing.Point(10, 173);
            this.cb_portArrive.Name = "cb_portArrive";
            this.cb_portArrive.Size = new System.Drawing.Size(158, 23);
            this.cb_portArrive.TabIndex = 20;
            this.cb_portArrive.Text = "Port arrivé";
            // 
            // cb_portDepart
            // 
            this.cb_portDepart.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_portDepart.FormattingEnabled = true;
            this.cb_portDepart.Location = new System.Drawing.Point(10, 121);
            this.cb_portDepart.Name = "cb_portDepart";
            this.cb_portDepart.Size = new System.Drawing.Size(160, 23);
            this.cb_portDepart.TabIndex = 19;
            this.cb_portDepart.Text = "Port d\'épart";
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Ajouter.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(24, 213);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(132, 34);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // tb_ajouter_numLiaison
            // 
            this.tb_ajouter_numLiaison.Location = new System.Drawing.Point(135, 8);
            this.tb_ajouter_numLiaison.Name = "tb_ajouter_numLiaison";
            this.tb_ajouter_numLiaison.Size = new System.Drawing.Size(39, 22);
            this.tb_ajouter_numLiaison.TabIndex = 10;
            // 
            // Ports
            // 
            this.Ports.AutoSize = true;
            this.Ports.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ports.Location = new System.Drawing.Point(10, 71);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(58, 22);
            this.Ports.TabIndex = 11;
            this.Ports.Text = "Ports";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(13, 11);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(113, 16);
            this.numero.TabIndex = 5;
            this.numero.Text = "numéro de liaison";
            // 
            // lb_ajouter_Duree
            // 
            this.lb_ajouter_Duree.AutoSize = true;
            this.lb_ajouter_Duree.Location = new System.Drawing.Point(13, 40);
            this.lb_ajouter_Duree.Name = "lb_ajouter_Duree";
            this.lb_ajouter_Duree.Size = new System.Drawing.Size(42, 16);
            this.lb_ajouter_Duree.TabIndex = 13;
            this.lb_ajouter_Duree.Text = "durée";
            // 
            // tb_ajouter_Duree
            // 
            this.tb_ajouter_Duree.Location = new System.Drawing.Point(61, 37);
            this.tb_ajouter_Duree.Name = "tb_ajouter_Duree";
            this.tb_ajouter_Duree.Size = new System.Drawing.Size(113, 22);
            this.tb_ajouter_Duree.TabIndex = 14;
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.LightGreen;
            this.Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retour.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ForeColor = System.Drawing.Color.Teal;
            this.Retour.Location = new System.Drawing.Point(24, 7);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(151, 53);
            this.Retour.TabIndex = 6;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 66);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIAISONS";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(490, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 66);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lb_numSecteur
            // 
            this.lb_numSecteur.AutoSize = true;
            this.lb_numSecteur.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numSecteur.ForeColor = System.Drawing.Color.Red;
            this.lb_numSecteur.Location = new System.Drawing.Point(423, 75);
            this.lb_numSecteur.Name = "lb_numSecteur";
            this.lb_numSecteur.Size = new System.Drawing.Size(89, 24);
            this.lb_numSecteur.TabIndex = 4;
            this.lb_numSecteur.Text = "Secteur 3";
            // 
            // lb_nombre_secteurs
            // 
            this.lb_nombre_secteurs.AutoSize = true;
            this.lb_nombre_secteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_secteurs.Location = new System.Drawing.Point(496, 466);
            this.lb_nombre_secteurs.Name = "lb_nombre_secteurs";
            this.lb_nombre_secteurs.Size = new System.Drawing.Size(185, 20);
            this.lb_nombre_secteurs.TabIndex = 6;
            this.lb_nombre_secteurs.Text = "nombre de liaisons =";
            // 
            // Liaisons_Form
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.lb_nombre_secteurs);
            this.Controls.Add(this.lb_numSecteur);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbLiaisons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liaisons_Form";
            this.Text = "gestion Scilylines";
            this.Load += new System.EventHandler(this.gestionScilylines_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLiaisons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label Ports;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ajouter_numLiaison;
        private System.Windows.Forms.TextBox tb_modification_Duree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ajouter_Duree;
        private System.Windows.Forms.TextBox tb_ajouter_Duree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label lb_numSecteur;
        private System.Windows.Forms.ComboBox cb_portDepart;
        private System.Windows.Forms.ComboBox cb_portArrive;
        private System.Windows.Forms.Label lb_nombre_secteurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

