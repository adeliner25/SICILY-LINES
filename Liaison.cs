using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission2.Modele;
using Mission2.DAL;

namespace Mission2
{
    public class Liaison
    {
        private int id_Liaison;
        private string duree;
        private Secteur secteur;
        private string description;
        private Port Port_Depart;
        private Port Port_Arrivee;

        // Constructeurs avec parametres
        public Liaison(int pIdLiaison, string pDuree, Secteur pSecteur, Port pPortDepart, Port pPortArrive)
        {
            this.id_Liaison = pIdLiaison;
            this.duree = pDuree;
            this.secteur = pSecteur;
            this.Port_Depart = pPortDepart;
            this.Port_Arrivee = pPortArrive;
        }
        public Liaison(string pDuree, Secteur pSecteur, Port pPortDepart, Port pPortArrive)
        {
            this.duree = pDuree;
            this.secteur = pSecteur;
            this.Port_Depart = pPortDepart;
            this.Port_Arrivee = pPortArrive;
        }
        public Liaison(string pDuree, Port pPortDepart, Port pPortArrive)
        {
            this.duree = pDuree;
            this.Port_Depart = pPortDepart;
            this.Port_Arrivee = pPortArrive;
        }
        public Liaison(int pIdLiaison, string pDuree)
        {
            this.id_Liaison = pIdLiaison ;
            this.duree = pDuree ;
        }
        public Liaison(string pDuree)
        {
            this.duree = pDuree;
        }

        // Getters
        public int getId()
        {
            return this.id_Liaison;
        }
        public string getDuree()
        {
            return this.duree;
        }
        public Port getPort_Depart()
        {
            // On retourne le Port de départ qui se trouve dans liaison
            return this.Port_Depart;
        }
        public Port getPort_Arrivee()
        {
            // On retourne le Port d'arrivee qui se trouve dans la liaison
            return this.Port_Arrivee;
        }
        public Secteur getSecteur()
        {
            return this.secteur;
        }

        // Setter
        public void setDuree(string pDuree)
        {
            this.duree = pDuree;
        }
        
        public string Description
        {
            get
            {
                // description qui sera afficher dans la listBox
                this.description = "num liaison " + this.id_Liaison + " || Port départ : " + getPort_Depart().getNom() + " || Port Arrive : " + getPort_Arrivee().getNom() + " || durée : " + this.duree;
                return this.description;
            }
        }
    }
}