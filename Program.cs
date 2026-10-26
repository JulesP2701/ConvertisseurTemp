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
        int nombre = Console.ReadLine(int.Parse(reponse));
        Console.WriteLine("Entrer votre choix ( 1 ou 2) : ");






    }
}