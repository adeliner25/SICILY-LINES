using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2.Vue
{
    public partial class Accueil_Form : Form
    {
        public Accueil_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entrer_Click(object sender, EventArgs e)
        {
            Secteurs_Form FenetreSecteurs = new Secteurs_Form();
            FenetreSecteurs.StartPosition = FormStartPosition.CenterParent;
            FenetreSecteurs.ShowDialog();
        }
    }
}
