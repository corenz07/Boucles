namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        // Etape 1 : faire un compteur qui va de 1 à 10
        int number = 0;
            for(int i = 0; i<10; i++)
            {
                number++;
            Console.WriteLine(number);
            }
        
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
         number = 6;
        for(int i = 0; i<5; i++)
        {
            number -= 1;
            Console.WriteLine(number);
            if(number == 1)
            {
                break;
            }
        }
        Console.WriteLine("Bonne année !");
        // Etape 3 : faire un compteur qui va de -4 à 2
        number = -5;
        for(int i = 0; i<7; i++)
        {
            number++;
            Console.WriteLine(number);
        }
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        number = 0;
        while (number < 15)
        {
            number += 2;
            if (number == 16)
            {
                break;
            }
            Console.WriteLine(number);
           
        }
        Console.WriteLine(number -= 1);
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        for(int i =0; i<i+1; i++)
        {
            Console.WriteLine("Êtes-vous un humain?");
            String answer = Console.ReadLine();
            if(answer == "oui")
            {
                break;
            }
            else
            {
                Console.WriteLine("Menteur !");
            }
        }

        }
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}