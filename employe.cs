using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Employe
    {
        private int numero;
        private string nom;
        private int anneeEmbauche;
        private Grade leGrade;
        public Employe(int numero, string nom,int annee,Grade g)
        {
            this.numero = numero; this.nom = nom;
            this.anneeEmbauche = annee;
            this.leGrade = g;

        }
		//La méthode CoûtHoraire détermine et retourne le coût horaire de l'employé
		//en fonction de sa qualification et de son ancienneté
		/*de 5 à 10 ans majoration de 5 %
• de 11 à 15 ans majoration de 8 %
• plus de 15 ans majoration de 12 %*/
		
		public double coutHoraire()
        {
			double coutHoraire = 0;
			DateTime date1 = DateTime.Now;
			int annee = this.anneeEmbauche - date1.Year;
			if (annee >= 5 && annee <= 10)
			{
				coutHoraire = this.leGrade.getTaux() * 1.05;
			}
			else
				if (annee >= 11 && annee >= 15)
			{
				coutHoraire = this.leGrade.getTaux() * 1.08;
			}
			else
				coutHoraire = this.leGrade.getTaux() * 1.12 ;

			return coutHoraire;
        }
    }
}
