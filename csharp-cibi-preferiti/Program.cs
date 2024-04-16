namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favouriteFoods = { "Pizza", "Pasta", "Risotto", "Fiorentina", "Hamburger", "Sushi"};
            Console.WriteLine($"La mia lista contiene {favouriteFoods.Length} cibi. \n");

            Console.WriteLine("Ecco la mia lista:");

            for(int i = 0; i< favouriteFoods.Length; i++)
            { 
                Console.WriteLine($"{i+1}. {favouriteFoods[i]}"); 
            }

            Console.WriteLine($"\nIl mio cibo preferito è: {favouriteFoods[0]}. \nMentre il mio cibo preferito ma non troppo è: {favouriteFoods[favouriteFoods.Length-1]}.");
       
            //bonus

            if(favouriteFoods.Length % 2 == 0)
            {
                Console.WriteLine($"\nI cibi che stanno in mezzo alla mia classifica sono: {favouriteFoods[(favouriteFoods.Length / 2) - 1]} e {favouriteFoods[favouriteFoods.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"\nIl cibo che sta a metà della mia classifica è {favouriteFoods[((favouriteFoods.Length + 1) / 2)-1]}");
            }
        }
    }
}
