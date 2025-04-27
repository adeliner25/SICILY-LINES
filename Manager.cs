using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission2.Modele;
using Mission2.DAL;

namespace Mission2.Controleur
{
     class Manager
    {
        // Cr�ation des listes (collections)
        private List<Liaison> ListeLiaisons;
        private List<Secteur> ListeSecteurs;
        private List<Port> ListePorts;
        
        // Cr�ation d'un constructeur par d�fault
        public Manager()
        {
            this.ListeLiaisons = new List<Liaison>();
        }

        // Fonction chargementLiaisonsBaseDonnee() qui appelle la fonction static getLiaison()
        // et qui retourne la liste des liaison qui se trouve dans la base de donn�es
        public List<Liaison> chargementLiaisonsBaseDonnee()
        {
            ListeLiaisons = LiaisonDAO.getLiaisons();
            return this.ListeLiaisons;
        }
        public List<Port> chargementPortsBaseDonnee()
        {
            ListePorts = PortDAO.getPorts();
            return this.ListePorts;
        }
        // Fonction chargemenSecteursBaseDonnee() qui appelle la fonction static getSecteur()
        // et qui retourne la liste des liaison qui se trouve dans la base de donn�es
        public List<Secteur> chargemenSecteursBaseDonnee()
        {
            ListeSecteurs = SecteurDAO.getSecteur();
            return this.ListeSecteurs;
        }

        // Les 3 m�thodes du dessous font appellent aux fonctions insertion, supprimer et modifier
        // qui sont static de LiaisonDAO
        public void insertionLiaison(Liaison pLiaison)
        {
            LiaisonDAO.ajoutLiaison(pLiaison);
        }
        public void SuppressionLiaison(Liaison pLiaison)
        {
            LiaisonDAO.supprimeLiaison(pLiaison);
        }
        public void modificationLiaison(Liaison pLiaison)
        {
            LiaisonDAO.modificationLiaison(pLiaison);
        }

    }
}
