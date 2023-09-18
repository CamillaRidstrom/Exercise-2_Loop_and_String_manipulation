namespace Exercise_2_Loop_and_String_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Huvudmeny

            bool a = false;

            do
            {
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("This is the main menu.\nHere you can navigate by entering numbers to test different functions.\n");

                //Menyalternativen
                Console.WriteLine("0. Quit application");
                Console.WriteLine("1. Get movie ticket price for 1 person");
                Console.WriteLine("2. Get movie ticket price for more then 1 person");
                Console.WriteLine("3. Detention-time function ;D ");
                Console.WriteLine("4. The third word");
                //Console.WriteLine("1. Nånting");

                Console.WriteLine("\nPlease enter your choice: ");
                string selectedAction = Console.ReadLine();


                switch (selectedAction)
                {
                    case "0": // Hoppa ur menyn

                        Console.Write("\nClosing menu... You can now exit application.\n");
                        a = true; // Den här raden gör inget i nuläget
                        //Environment.Exit(0); //Det här funkar i Switch utan Do-while men ej med båda, men bra att kolla upp mer 
                        break;



                    case "1": // Biljettpris för 1 person utifrån ålder

                        Console.Write("\nWelcome to your local cinema.\nLet us tell you how much a ticket for tonight's screening costs.\n\nPlease enter your age: ");

                        int selectedAge = int.Parse(Console.ReadLine());

                        if (selectedAge < 20)
                        {
                            Console.WriteLine("\nYouth tickets are 80 SEK each.\n");
                        }
                        else if (selectedAge > 64)
                        {
                            Console.WriteLine("\nSenior citizens tickets are 90 SEK each.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nRegular tickets are 120 SEK each.\n");
                        }
                        break;






                    case "2": // Biljettpris för en grupp personer med åldersbaserad prissättning

                        Console.WriteLine("\nWelcome to your local cinema. \nLet us tell you how much a ticket for tonight's screening costs for you and your companions. \nPlease enter the number of tickets needed: \n");

                        int length = int.Parse(Console.ReadLine()); // Låter användaren ange antal besökare

                        int[] visitorIDs = new int[length];

                        var visitorAge = visitorIDs[0];

                        //Console.WriteLine("Number of visitors: " + length);

                        int sum = 0;
                        int quantity = 0;

                        for (int i = 0; i < length; i++) // Låter användaren ange vilka åldrar
                        {
                            int x = i + 1;
                            Console.WriteLine("Please enter the age of visitor " + x + ": ");
                            int age = int.Parse(Console.ReadLine());
                            visitorIDs[i] = age;
                        }
                        for (int j = 0; j < visitorIDs.Length; j++)
                        {
                            if (visitorIDs[j] < 20)
                            {
                                sum += 80;
                                quantity += 1;
                            }

                            else if (visitorIDs[j] > 64)
                            {
                                sum += 90;
                                quantity += 1;

                            }
                            else
                            {
                                sum += 120;
                                quantity += 1;
                            }
                        }
                        Console.WriteLine("We have available tickets for the " + quantity + " of you!");
                        Console.WriteLine("Ticket price for the whole party " + sum + " SEK.");

                        break;





                    case "3": // Upprepar input 10 gånger

                        Console.Write("\nDetention-time function.\nThis function will take you back to school the Simpsons style.\nYou are in detention staying in class after school, having to write the same sentence over and over.\nWhat will you have Bart Simpson write?\n\nPlease enter a sentence: ");

                        string detentionPhrase = Console.ReadLine();

                        Console.WriteLine("\n");

                        for (var i = 0; i < 10; i++)
                        {
                            Console.Write(detentionPhrase + " ");
                        }
                        Console.WriteLine("\n");

                        break;






                    case "4": // Plockar ut det tredje ordet från en mening

                        Console.Write("\nPlease write a sentence with at least 3 words: ");
                        string user3wordSentence = Console.ReadLine();

                        string[] words = user3wordSentence.Split(' ');

                        Console.Write("\nThe third word you wrote was: " + words[2] + "\n");

                        break;


                    default: //Fångar upp om ingen giltig siffra (menyval) anges

                        Console.WriteLine("\nInvalid input\n");
                        break;

                }
            }
            while (a != true); // Avslutar menyn (hade även velat stänga ner automatiskt)
            {
                Environment.Exit(0); //Funkar ej här - varför? //Funkar inuti en oinkapslad Switch
            }
        }
    }
}