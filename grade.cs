using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Grade
    {
        private char code;
        private string libelle;
        private double taux;
        public Grade(char code, string libelle, double taux)
        {
            this.code = code;
            this.libelle = libelle;
            this.taux = taux;
        }
        public double getTaux()
        {
            return this.taux;
        }
    }
}
