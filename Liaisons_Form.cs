using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mission2.Modele;
using Mission2.Controleur;
using Mission2.Vue;
using MySql.Data.MySqlClient;

namespace Mission2
{
    public partial class Liaisons_Form : Form
    {
        private Manager manager = new Manager();
        private List<Liaison> listeLiaisons = new List<Liaison>();
        private List<Port> listePortsDepart = new List<Port>();
        private List<Port> listePortsArrive = new List<Port>();
        int numeroSecteur;

        public Liaisons_Form()
        {
            InitializeComponent();
        }
        public Liaisons_Form(int pNumeroSecteur)
        {
            InitializeComponent();
            numeroSecteur = pNumeroSecteur + 1;
        }
        private void gestionScilylines_Load(object sender, EventArgs e)
        {
            listePortsDepart = manager.chargementPortsBaseDonnee();
            listePortsArrive = manager.chargementPortsBaseDonnee();
            initialisationComboBoxPortsDeparts();
            initialisationComboBoxPortsArrives();
            listeLiaisons = manager.chargementLiaisonsBaseDonnee();
            Affichage();
        }
        private void AffichageInterface()
        {
            // Affichage interface
            lb_numSecteur.Text = "Secteur " + numeroSecteur;
            lb_nombre_secteurs.Text = "nombre de liaisons = " + listeLiaisons.Count; // Affichage du nombre de secteurs 
        }
        public void initialisationComboBoxPortsDeparts()
        {
                cb_portDepart.DataSource = null;
                cb_portDepart.DataSource = listePortsDepart;
                cb_portDepart.DisplayMember = "Description";
        }
        public void initialisationComboBoxPortsArrives()
        {
            cb_portArrive.DataSource = null;
            cb_portArrive.DataSource = listePortsArrive;
            cb_portArrive.DisplayMember = "Description";
        }

        public void Affichage()
        {
            try
            {
                lbLiaisons.DataSource = null;
                lbLiaisons.DataSource = listeLiaisons;
                lbLiaisons.DisplayMember = "Description";
                AffichageInterface();
            } catch(Exception emp)
            {
                throw (emp);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int numLiaison = Convert.ToInt32(tb_ajouter_numLiaison.Text);
            string duree = tb_ajouter_Duree.Text;
            if(tb_ajouter_numLiaison.Text == null)
            {
                Exception_Form exception = new Exception_Form("Vous n'avez rien saisi comme numéro de liaison");
                exception.ShowDialog();
            }
            Secteur secteur = new Secteur(numeroSecteur);


            Port portDepart = (Port)cb_portDepart.SelectedItem;
            Port portArrive = (Port)cb_portArrive.SelectedItem;

            Liaison liaison = new Liaison(numLiaison, duree, secteur, portDepart, portArrive);
            
            // Condition qui permet de ne pas avoir le même nom de port de départ et d'arrivé
            if (portDepart.getNom() == portArrive.getNom())
            {
                Exception_Form exception_fenetre = new Exception_Form("Le nom du port de départ et le nom de port d'arrivé sont identiques");
                exception_fenetre.StartPosition = FormStartPosition.CenterParent;
                exception_fenetre.ShowDialog();
                return; // On quitte la méthode sans ajouter de liaison
            }
            try
            {
                manager.insertionLiaison(liaison);
                
                listeLiaisons = manager.chargementLiaisonsBaseDonnee();
                Affichage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pour l'ajout de la liason : " + ex.Message);
            }    
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Liaison liaison = (Liaison)lbLiaisons.SelectedItem;
            manager.SuppressionLiaison(liaison);
            listeLiaisons = manager.chargementLiaisonsBaseDonnee();
            Affichage();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Liaison liaison = (Liaison)lbLiaisons.SelectedItem;
            liaison.setDuree(tb_modification_Duree.Text);
            manager.modificationLiaison(liaison);
            listeLiaisons = manager.chargementLiaisonsBaseDonnee();
            Affichage();
        }

    }
}
