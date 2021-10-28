using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime,
            //programm küsib kasutajal siestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            // kui kasutaja siestab '3', siis kuvatakse kasutaja eesnimine pikkust


            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();


            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)

            {
                case '1':
                    userNameReversed(userName);
                    break;
                case '2':
                    userNameFirstChar(userName);
                    break;
                case '3':
                    userNameLength(userName);
                break;
            }


        }
        public static void userNameReversed(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        
        }   
        
        public static void userNameFirstChar(string userInput)
         {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
         }

        public static void userNameLength (string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }



            


        
    }
}
