using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative2
{
    // Définition de la classe Consultation
    internal class Consultation
    {
        // Propriétés de la classe
        private DateTime date;
        private string raison;

        // Accesseurs pour les propriétés ; get : recupère la valeur et set : permet de définir la valeur
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Raison
        {
            get { return raison; }
            set { raison = value; }
        }

        // Constructeur avec une seule argument : la date et la raison est par défaut : "Non définie"
        public Consultation(DateTime date)
        {
            this.date = date;
            this.raison = "Non définie";
        }

        // Constructeur avec deux arguments : la date et la raison
        public Consultation(DateTime date, string raison)
        {
            this.date = date;
            this.raison = raison;
        }

        /// <summary>
        /// Définition de la méthode ToString pour afficher les informations sur le patient et son historique de consultations.
        /// </summary>
        /// <returns>Une chaîne de caractères contenant les informations sur la consultation.</returns>
        public override string ToString()
        {
            return $" La consultation est faite le : {date.ToString("yyyy-MM-dd")} | La raison est : {raison}\n";
        }
    }
}
