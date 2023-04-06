using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSommative2
{
    /// <summary>
    /// Classe représentant un médecin avec ses attributs et ses méthodes.
    /// </summary>
    internal class Medecin
    {
            // Propriétés de la classe
            private string nom;
            private string prenom;
            private DateTime dateNaissance;
            private List<Patient> patients;

            /// <summary>
            /// Propriétés pour accéder et modifier le nom, le prénom, la date de naissance du médecin et la liste des patients
            /// </summary>
            public string Nom
            {
                get { return nom.ToUpper(); } // le nom est stocké en majuscules
                set { nom = value; }
            }

            public string Prenom
            {
                get { return prenom.ToLower(); } // le prénom est stocké en minuscules
                set { prenom = value; }
            }

            public DateTime DateNaissance
            {
                get { return dateNaissance; }
                set { dateNaissance = value; }
            }

            public List<Patient> Patients
            {
                get { return patients; }
                set { patients = value; }
            }

            /// <summary>
            /// Constructeur de la classe Medecin.
            /// </summary>
            /// <param name="Nom">Le nom du médecin.</param>
            /// <param name="Prenom">Le prénom du médecin.</param>
            /// <param name="dateDeNaissance">La date de naissance du médecin.</param>
            public Medecin(string Nom, string Prenom, DateTime dateDeNaissance)
            {
                this.nom = Nom;
                this.prenom = Prenom;
                this.dateNaissance = dateDeNaissance;
                this.patients = new List<Patient>();
            }

            /// <summary>
            /// Ajoute un patient à la liste des patients associés à ce médecin s'il n'est pas déjà dans la liste.
            /// </summary>
            /// <param name="patient">Le patient à ajouter.</param>
            public void AjouterPatient(Patient patient)
            {
                if (!patients.Contains(patient))
                {
                    patients.Add(patient);
                }
            }

            /// <summary>
            /// Retire un patient de la liste des patients associés à ce médecin s'il est dans la liste.
            /// </summary>
            /// <param name="patient">Le patient à retirer.</param>
            public void RetirerPatient(Patient patient)
            {
                if (patients.Contains(patient))
                {
                    patients.Remove(patient);
                }
                else
                {
                    Console.WriteLine("Le patient n'est pas dans la liste.");
                }
            }

            /// <summary>
            /// Ajoute une consultation à la liste des consultations d'un patient associé à ce médecin.
            /// Si le patient n'est pas déjà associé à ce médecin ça s'ajoute à sa liste de patients.
            /// </summary>
            /// <param name="patient">Le patient à associer à cette consultation.</param>
            /// <param name="consultation">La consultation à ajouter.</param>
            public void AjouterVisite(Patient patient, Consultation consultation)
            {
                if (!patients.Contains(patient))
                {
                    AjouterPatient(patient);
                }
                patient.AjouterVisite(consultation);
            }

            /// <summary>
            /// Vérifie si deux médecins sont égaux en comparant leur nom, prénom et date de naissance.
            /// </summary>
            /// <param name="medecinPasse">Le médecin à comparer.</param>
            /// <returns>True si les deux médecins sont égaux, sinon False.</returns>
            public bool Equals(Medecin medecinPasse)
            {
                if (medecinPasse == null)
                {
                    return false;
                }

                return (this.nom.ToUpper() == medecinPasse.nom.ToUpper()) &&
                       (this.prenom.ToLower() == medecinPasse.prenom.ToLower()) &&
                       (this.dateNaissance == medecinPasse.dateNaissance);
            }

            /// <summary>
            /// Vérifie si deux médecins sont égaux en comparant leur nom, prénom et date de naissance.
            /// </summary>
            /// <param name="medecin1">Le premier médecin à comparer.</param>
            /// <param name="medecin2">Le deuxième médecin à comparer.</param>
            /// <returns>True si les deux médecins sont égaux, sinon False.</returns>
            public static bool operator ==(Medecin medecin1, Medecin medecin2)
            {
                if (ReferenceEquals(medecin1, medecin2))
                {
                    return true;
                }

                if (medecin1 is null || medecin2 is null)
                {
                    return false;
                }

                return medecin1.Equals(medecin2);
            }

            /// <summary>
            /// Vérifie si deux médecins sont différents en comparant leur nom, prénom et date de naissance.
            /// </summary>
            /// <param name="medecin1">Le premier médecin à comparer.</param>
            /// <param name="medecin2">Le deuxième médecin à comparer.</param>
            /// <returns>True si les deux médecins sont différents, sinon False.</returns>
            public static bool operator !=(Medecin medecin1, Medecin medecin2)
            {
                return !(medecin1 == medecin2);
            }

            /// <summary>
            /// Définition de la méthode ToString pour afficher les informations sur le médecin et sa liste des patients.
            /// </summary>
            /// <returns>Une chaîne de caractères contenant les informations sur le medecin et sa liste des patients.</returns>
            public override string ToString()
            {
                string resultat = $" Nom du medecin : {Nom}, Prénom du medecin : {Prenom}, Date de naissance : {DateNaissance.ToShortDateString()}";
                if (patients.Count == 0)
                {
                    resultat += "\n Aucun patient pour le moment";
                }
                else
                {
                    resultat += "\n Liste des patients : ";
                    foreach (Patient patient in patients)
                    {
                        resultat += "\n" + patient.ToString();
                    }
                }
                return resultat;
            }
    }
}
