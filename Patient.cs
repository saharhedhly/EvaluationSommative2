using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative2
{
    // Définition de la classe Consultation
    internal class Patient
    {
        // Propriétés de la classe
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private Consultation consultationFuture;
        private List<Consultation> historiqueConsultations;

        // Propriété en lecture/écriture pour le nom, le prénom, la date de naissance, la consultation future et l'historique des consultations
        public string Nom
        {
            get { return nom.ToUpper(); } // le nom est stocké en majuscules
            set { nom = value.ToUpper(); }
        }

        public string Prenom
        {
            get { return prenom.ToLower(); } // le prénom est stocké en minuscules
            set { prenom = value.ToLower(); }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public Consultation ConsultationFuture
        {
            get { return consultationFuture; }
            set { consultationFuture = value; }
        }

        public List<Consultation> HistoriqueConsultations
        {
            get { return historiqueConsultations; }
            set { historiqueConsultations = value; }
        }

        // Constructeur de la classe pour initialiser un patient sans consultation future
        public Patient(string Nom, string Prenom, DateTime DateDeNaissance)
        {
            this.nom = Nom.ToUpper();
            this.prenom = Prenom.ToLower();
            this.dateNaissance= DateDeNaissance;
            this.historiqueConsultations = new List<Consultation>();
        }

        // Constructeur de la classe pour initialiser un patient avec une consultation future
        public Patient(string Nom, string Prenom, DateTime DateDeNaissance, Consultation ConsultationFuture)
        {
            this.nom = Nom.ToUpper();
            this.prenom = Prenom.ToLower();
            this.dateNaissance = DateDeNaissance;
            this.consultationFuture = ConsultationFuture;
            this.historiqueConsultations = new List<Consultation>();
        }

        /// <summary>
        /// Ajoute la prochaine consultation à l'historique des consultations du patient.
        /// </summary>
        /// <param name="consultation">La consultation à ajouter.</param>
        public void AjouterVisite(Consultation consultation)
        {
            consultationFuture = consultation;
        }

        /// <summary>
        /// Ajoute la prochaine consultation à l'historique des consultations du patient et efface la prochaine consultation.
        /// </summary>
        public void VisiteEffectuee()
        {
            historiqueConsultations.Add(consultationFuture);
            consultationFuture = null;
        }

        /// <summary>
        /// Définition de la méthode Equals pour vérifier l'égalité entre deux objets Patient.
        /// </summary>
        /// <param name="patientPasse">L'objet Patient à comparer.</param>
        /// <returns>True si les deux objets sont égaux, False sinon.</returns>
        public bool Equals(Patient patientPasse)
        {
            if (patientPasse == null)
            {
                return false;
            }

            return (this.nom.ToUpper() == patientPasse.nom.ToUpper()) &&
                   (this.prenom.ToLower() == patientPasse.prenom.ToLower()) &&
                   (this.dateNaissance == patientPasse.dateNaissance);
        }

        /// <summary>
        /// Définition de l'opérateur de comparaison == pour vérifier l'égalité entre deux objets Patient.
        /// </summary>
        /// <param name="patient1">Le premier objet Patient à comparer.</param>
        /// <param name="patient2">Le deuxième objet Patient à comparer.</param>
        /// <returns>True si les deux objets sont égaux, sinon False.</returns>
        public static bool operator ==(Patient patient1, Patient patient2)
        {
            if (ReferenceEquals(patient1, patient2))
            {
                return true;
            }

            if (patient1 is null || patient2 is null)
            {
                return false;
            }

            return patient1.Equals(patient2);
        }

        /// <summary>
        /// Définition de l'opérateur de comparaison != pour vérifier l'inégalité entre deux objets Patient.
        /// </summary>
        /// <param name="patient1">Le premier objet Patient à comparer.</param>
        /// <param name="patient2">Le deuxième objet Patient à comparer.</param>
        /// <returns>True si les deux objets sont différents, sinon False.</returns>
        public static bool operator !=(Patient patient1, Patient patient2)
        {
            return !(patient1 == patient2);
        }

        /// <summary>
        /// Définition de la méthode ToString pour afficher les informations sur le patient et son historique de consultations.
        /// </summary>
        /// <returns>Une chaîne de caractères contenant les informations sur le patient et son historique de consultations.</returns>
        public override string ToString()
        {
            string resultat = $" Nom : {nom}, Prénom : {prenom}, Date de naissance : {dateNaissance.ToShortDateString()}";

            if (consultationFuture != null)
            {
                resultat += $"\n Consultation à venir : {consultationFuture.ToString()}\n";
            }
            else
            {
                resultat += "\n Pas de consultation à venir\n";
            }

            if (historiqueConsultations.Count > 0)
            {
                resultat += " Historique des consultations du patient : \n";
                foreach (Consultation consultation in this.historiqueConsultations)
                {
                    if (consultation != null)
                    {
                        resultat += consultation.ToString() + "\n";
                    }
                }
            }
            else
            {
                resultat += " Pas d'historique de consultations";
            }

            return resultat;
        }

    }
}
