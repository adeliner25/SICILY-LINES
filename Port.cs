using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.Modele
{
    public class Port
    {
        // Attributs/Propriétés
        private int id_Port;
        private int numero_Liaison;
        private string nom;

        // Constructeurs
        public Port(int pId_Port, int pNumero_Liaison, string pNom)
        {
            this.id_Port = pId_Port;
            this.numero_Liaison = pNumero_Liaison;
            this.nom = pNom;
        }
        public Port(int pId_Port, string pNom)
        {
            this.id_Port= pId_Port;
            this.nom = pNom;
        }
        public Port(int pId_Port)
        {
            id_Port = pId_Port;
        }
        public Port(string pNom)
        {
            this.nom = pNom;
        }

        // Getters
        public string getNom()
        {
            return this.nom;
        }
        public int getId_Port()
        {
            return id_Port;
        }

        // Setter
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string Description
        {
            get => this.nom;
        }

    }
}
