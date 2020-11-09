using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Contrat
    {
        private int numero;
        private DateTime date;
        private double montantContrat;
        private Client leClient;
        private List<Intervention> lesInterventions;
        public Contrat(int num, DateTime date, double montant, Client c)
        {
            this.date = date; this.leClient = c; this.numero = num; this.montantContrat = montant;
            this.lesInterventions = new List<Intervention>();
        }
        public void ajouterIntervention(Intervention i)
        {
            this.lesInterventions.Add(i);
        }
        public double getMontantContrat() { return this.montantContrat; }

        //La méthode Écart détermine et retourne l’écart entre le montant
        //du contrat et le coût des interventions effectuées sur ce contrat 
        public double ecart()
        {
            
            return 0;
        }
    }
}
