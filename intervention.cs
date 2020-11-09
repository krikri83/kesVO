using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Intervention
    {
        private int numero;
        private DateTime date;
        private int duree;
        private double tarifKm; //tarif kilométrique retenu 
        private Employe unEmploye;
        public Intervention(int num, DateTime d, int duree, double t, Employe e)
        {
            this.numero = num;
            this.date = d;
            this.duree = duree;
            this.tarifKm = t;
            this.unEmploye = e;
        }
        // La méthode FraisKm de la classe Intervention calcule les frais kilométriques occasionnés
        // par une intervention, la distance parcourue étant passée en paramètre. 
        public double fraisKm(double distance) 
        {
			double frais = 0;
			while(frais < distance)
			{
				frais *= this.tarifKm;
				frais++;
			}
            return frais;
        }
        
        //La méthode FraisMo calcule et retourne les frais de main-d'œuvre occasionnés par une intervention. 
        public double fraisMo() 
        {
			double coutFrais;
			coutFrais = this.unEmploye.coutHoraire();
			coutFrais = coutFrais * this.duree;
            return coutFrais;           
        }
    }
}
