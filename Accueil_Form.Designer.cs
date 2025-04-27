namespace Mission2.Vue
{
    partial class Accueil_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Scicylines = new System.Windows.Forms.Label();
            this.Entrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Scicylines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(679, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 66);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Scicylines
            // 
            this.Scicylines.AutoSize = true;
            this.Scicylines.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scicylines.ForeColor = System.Drawing.Color.White;
            this.Scicylines.Location = new System.Drawing.Point(207, 11);
            this.Scicylines.Name = "Scicylines";
            this.Scicylines.Size = new System.Drawing.Size(373, 34);
            this.Scicylines.TabIndex = 0;
            this.Scicylines.Text = "𝓒𝓸𝓶𝓹𝓪𝓰𝓷𝓲𝓮  𝓢𝓲𝓬𝓲𝓵𝔂  𝓛𝓲𝓷𝓮𝓼";
            // 
            // Entrer
            // 
            this.Entrer.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Entrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Entrer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrer.ForeColor = System.Drawing.Color.White;
            this.Entrer.Location = new System.Drawing.Point(270, 369);
            this.Entrer.Name = "Entrer";
            this.Entrer.Size = new System.Drawing.Size(209, 46);
            this.Entrer.TabIndex = 2;
            this.Entrer.Text = "Entrer";
            this.Entrer.UseVisualStyleBackColor = false;
            this.Entrer.Click += new System.EventHandler(this.Entrer_Click);
            // 
            // Accueil_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Entrer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil_Form";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Scicylines;
        private System.Windows.Forms.Button Entrer;
        private System.Windows.Forms.Button Exit;
    }
}