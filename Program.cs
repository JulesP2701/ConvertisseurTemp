using System.Text;

namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        Console.WriteLine("==== CONVERTISSEUR DE TEMPERATURE ====");
        Console.WriteLine("1. De Celsius à Fahrenheit");
        Console.WriteLine("2. De Fahrenheit à Celsius");
        string reponse = Console.ReadLine();
        int nombre = int.Parse(reponse);
        Console.WriteLine($"Entrer votre choix ( 1 ou 2) : {nombre} ");
        if ( nombre == 1 )
        {

            Console.WriteLine(" Entrez une température en degrés Celsius, sans préciser l'unité (ex = 19,5) :");
            string reponse2 = Console.ReadLine();
            int nombre2 = int.Parse(reponse2);
            int resultat = (nombre2 * 9 / 5) + 32;
            Console.WriteLine($"Votre température vaut {resultat}°F");
            Console.WriteLine("Merci d'avoir utilisé notre convertisseur");
        }
        else if (nombre == 2)
        {

            Console.WriteLine(" Entrez une température en degrés Fahrenheit, sans préciser l'unité (ex = 19,5) :");
            string reponse2 = Console.ReadLine();
            int nombre2 = int.Parse(reponse2);
            int resultat2 = (nombre - 32) * 5/9;
            Console.WriteLine($"Votre température vaut {resultat2}°C");
            Console.WriteLine("Merci d'avoir utilisé notre convertisseur");

        }







    }
}