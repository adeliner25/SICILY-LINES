using Mission2.Controleur;
using Mission2.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2
{
    public partial class Secteurs_Form : Form
    {
        private Manager manager = new Manager();
        private List<Secteur> listeSecteurs = new List<Secteur>();
        private static int numSecteur;

        public Secteurs_Form()
        {
            InitializeComponent();
        }
        public static int getNumSecteur()
        {
            return numSecteur;
        }
        public void Affichage()
        {
            try
            {
                lbSecteurs.DataSource = null;
                lbSecteurs.DataSource = listeSecteurs;
                lbSecteurs.DisplayMember = "Description";
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Secteurs_Form_Load(object sender, EventArgs e)
        {
            listeSecteurs = manager.chargemenSecteursBaseDonnee();
            Affichage();
        }

        private void SelectionnerSecteur_Click(object sender, EventArgs e)
        {
            numSecteur = lbSecteurs.SelectedIndex; // on recupere l'index comme numéro de secteur
            Liaisons_Form liaisons_Form = new Liaisons_Form(numSecteur);
            liaisons_Form.StartPosition = FormStartPosition.CenterParent;
            liaisons_Form.ShowDialog(); 
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
