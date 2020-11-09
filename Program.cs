using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kes
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade g = new Grade('a', "développeur",100);
            Employe e = new Employe(10, "Dupond", 2000, g);

			/* question 1*/
			 Console.WriteLine(e.coutHoraire());// affiche 112
			
			/*question 2*/
			Intervention i = new Intervention(123, DateTime.Now, 4, 1.5, e);
			Console.WriteLine(i.fraisMo());  // affiche 448

			/* question 3*/
			Console.WriteLine(i.fraisKm(100)); // affiche 150

			/*Question 4*/
			//Client c = new Client(2,"Bison"," rue de Paris",50);
			//Contrat contrat = new Contrat(24, DateTime.Now, 1000, c);
			//contrat.ajouterIntervention(i);
			//Console.WriteLine(contrat.ecart()); // affiche 477



		}
    }
}
