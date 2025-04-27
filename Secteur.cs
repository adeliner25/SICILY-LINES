using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.Modele
{
    public class Secteur
    {
        private int id_Secteur;
        private string libelle;
        private string description;

        public Secteur(int pIdSecteur, string pLibelle)
        {
            this.id_Secteur = pIdSecteur;
            this.libelle = pLibelle;
        }
        public Secteur(int pIdSecteur)
        {
            this.id_Secteur = pIdSecteur;
        }
        public int getNumSecteur()
        {
            return this.id_Secteur;
        }
        public string Description
        {
            get
            {
                this.description = " Nom Secteur : " + this.libelle;
                return this.description;
            }
        }
    }
}
