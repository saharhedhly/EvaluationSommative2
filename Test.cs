using EvaluationSommative2;

internal class Test
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Test de la classe Consultation *****");
        DateTime date_0 = new DateTime(2022, 11, 13);
        Consultation consultation_0 = new Consultation(date_0);
        Console.WriteLine(consultation_0.ToString());
        Console.WriteLine("*******************");
        DateTime date_1 = new DateTime(2022, 11, 14);
        Consultation consultation_1 = new Consultation(date_1, "maux de tête");
        Console.WriteLine(consultation_1.ToString());

        Console.WriteLine("\n***** Test de la classe Patient *****");
        DateTime date_2 = new DateTime(1996, 10, 23);
        Patient patient_1 = new Patient("Ronaldo", "Cristiano", date_2);
        Console.WriteLine(patient_1.ToString());
        Console.WriteLine("*******************");
        patient_1.AjouterVisite(consultation_1);
        Console.WriteLine(patient_1.ToString());
        Console.WriteLine("*******************");
        patient_1.VisiteEffectuee();
        Console.WriteLine(patient_1.ToString());
        Console.WriteLine("*******************");
        DateTime date_3 = new DateTime(2004, 2, 2);
        Patient patient_2 = new Patient("Ronaldo", "Cristiano", date_3, consultation_0);
        Console.WriteLine(patient_2.ToString());
        Console.WriteLine("*******************");
        DateTime date_4 = new DateTime(2022, 11, 15);
        Consultation consultation_2 = new Consultation(date_4, "mal aux yeux");
        patient_2.AjouterVisite(consultation_2);
        Console.WriteLine(patient_2.ToString());
        Console.WriteLine("*******************");
        patient_2.VisiteEffectuee();
        Console.WriteLine(patient_2.ToString());
        Console.WriteLine("*******************");
        bool comparaison0 = patient_1 != patient_1;
        Console.WriteLine(comparaison0);
        Console.WriteLine("*******************");
        bool comparaison1 = patient_1 == patient_1;
        Console.WriteLine(comparaison1);
        Console.WriteLine("*******************");
        bool comparaison2 = patient_1 != patient_2;
        Console.WriteLine(comparaison2);
        Console.WriteLine("*******************");
        bool comparaison3 = patient_1 == patient_2;
        Console.WriteLine(comparaison3);

        Console.WriteLine("\n***** Test de la classe Medecin *****");
        DateTime date_6 = new DateTime(1980, 11, 20);
        Medecin medecinPrincipal = new Medecin("Audrey", "Dubois", date_6);
        bool comparaison4 = medecinPrincipal != medecinPrincipal;
        Console.WriteLine(comparaison4);
        Console.WriteLine("*******************");
        bool comparaison5 = medecinPrincipal == medecinPrincipal;
        Console.WriteLine(comparaison5);
        Console.WriteLine("*******************");
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        DateTime date_5 = new DateTime(1999, 12, 01);
        Patient patient_3 = new Patient("James", "Jean", date_5);
        medecinPrincipal.AjouterPatient(patient_3);
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        medecinPrincipal.AjouterPatient(patient_3);
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        medecinPrincipal.RetirerPatient(patient_3);
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        medecinPrincipal.AjouterVisite(patient_3, consultation_0);
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        patient_3.VisiteEffectuee();
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        medecinPrincipal.AjouterVisite(patient_3, consultation_1);
        Console.WriteLine(medecinPrincipal.ToString());
        Console.WriteLine("*******************");
        patient_3.VisiteEffectuee();
        Console.WriteLine(medecinPrincipal.ToString());
    }
}