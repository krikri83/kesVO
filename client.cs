using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Client
    {
        private int numero;
        private string nom;
        private string adresse;
        private int distance;  // distance du client à la société Kès en km 
        public Client(int num, string nom, string adresse, int distance)
        {
            this.numero = num; this.nom = nom; this.adresse = adresse; this.distance = distance;
        }
        public int getDistance() { return this.distance; }




        
    }
}
