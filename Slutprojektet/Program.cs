/*Hjälpkod för att komma igång
 * Notera att båda klasserna är i samma fil för att det ska underlätta.
 * Om programmet blir större bör man ha klasserna i separata filer såsom jag går genom i filmen
 * Då kan det vara läge att ställa in startvärden som jag gjort.
 * Man kan också skriva ut saker i konsollen i konstruktorn för att se att den "vaknar
 * Denna kod hjälper mest om du siktar mot betyget E och C
 * För högre betyg krävs mer självständigt arbete
 */
using System;
//Nedan är namnet på "namespace" - alltså projektet. 
//SKapa ett nytt konsollprojekt med namnet "Bussen" så kan ni kopiera över all koden rakt av från denna fil
namespace Bussen
{
    /*Börja längst ner i dokumentet och klassen "Program".
	Den klassen är liten och har i uppgiften att köra igång programmet genom att skapa en buss och sedan anropa metoden Run().
	I beskrivningen av projektet påpekas vikten av att koda stegvis. I detta fall kan det handla om att ni bara ska skriva
	ut en text i Run()-metoden.
	 */
    class Passagerare
    {
        private int age;
        private double height;
        private string sex;


        public Passagerare(int newAge, double newHeight, string newSex)
        {
            NewAge = newAge;
            NewHeight = newHeight;
            NewSex = newSex;
        }

        public int NewAge { get; }
        public double NewHeight { get; }
        public string NewSex { get; }

        public void react() // Reaction if poked
        {
            if (age <= 12) // Passenger under 12 is ticklish
            {
                Console.Clear();
                Console.WriteLine("Passageraren är kittlig");
                Console.WriteLine("*hihihihi*");
            }
            else if (age >= 13 && sex == "M") // Male passenger starts screaming
            {
                Console.Clear();
                Console.WriteLine("Passageraren blir arg");
                Console.WriteLine("*Sluta peta på mig!*");
            }
            else if (age >= 13 && sex == "K") // Female passenger asking you to stop poking
            {
                Console.Clear();
                Console.WriteLine("Passageraren blir arg");
                Console.WriteLine("*Snälla sluta peta på mig*");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
            }

        }


    }
    class Buss
    {

        Passagerare[] plats  = new Passagerare[25];
        public int antal_passagerare;


        public void Run()
        {
            Console.WriteLine("Welcome to the awesome Buss-simulator\n");
            string[] menuOptions = new string[] 
            { 
                "Lägg till passagerare\t",
                "Skriv ut fullständig passagerarlista\t\t", 
                "Skriv ut total ålder\t",
                "Beräkna medelålder\t",
                "Skriv ut äldsta passagerare\t",
                "Hitta passagerare i visst åldersspann\t",
                "Sortera passagera efter ålder\t",
                "Skriv ut passagerarnas kön\t",
                "Peta på en passagerare\t",
                "Ta bort en passagerare\t",
                "Avsluta\t"
            };
            int menuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;

                if (menuSelect == 0)
                {
                    Console.WriteLine("> " + menuOptions[0] + "<--");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                }
                else if (menuSelect == 1)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("> " + menuOptions[1] + "<--");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("> " + menuOptions[2] + "<--");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("> " + menuOptions[3] + "<--");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("> " + menuOptions[4] + "<--");
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                }
                else if (menuSelect == 5)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("> " + menuOptions[5] + "<--");
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 6)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine("> " + menuOptions[6] + "<--");
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 7)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine("> " + menuOptions[7] + "<--");
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 8)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine("> " + menuOptions[8] + "<--");
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 9)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine("> " + menuOptions[9] + "<--");
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 10)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine("> " + menuOptions[10] + "<--");
                    Console.WriteLine(menuOptions[11]);
                }
                else if (menuSelect == 11)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                    Console.WriteLine(menuOptions[6]);
                    Console.WriteLine(menuOptions[7]);
                    Console.WriteLine(menuOptions[8]);
                    Console.WriteLine(menuOptions[9]);
                    Console.WriteLine(menuOptions[10]);
                    Console.WriteLine("> " + menuOptions[11] + "<--");
                }
                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            add_passenger();
                            break;
                        case 1:
                            print_buss();
                            break;
                        case 2:
                            calc_total_age();
                            break;
                        case 3:
                            calc_average_age();
                            break;
                        case 4:
                            max_age();
                            break;
                        case 5:
                            find_age();
                            break;

                        case 6:
                            sort_buss();
                            break;

                        case 7:
                            print_sex();
                            break;

                        case 8:
                            poke();
                            break;
                        case 9:
                            getting_off();
                            break;
                        case 10:
                            break;


                    }
                }
                //Här ska menyn ligga för att göra saker
                //Jag rekommenderar switch och case här
                //I filmen nummer 1 för slutprojektet så skapar jag en meny på detta sätt.
                //Film nummer 1) https://youtu.be/GKC1QafdcM0 
                //Film nummer 2 (för elever som siktar mot A)) https://youtu.be/ztW9F8ip2f0
                //Dessutom visar jag hur man anropar metoderna nedan via menyn
                //Börja nu med att köra koden för att se att det fungerar innan ni sätter igång med menyn.
                //Bygg sedan steg-för-steg och testkör koden.
            }
        }

        //Metoder för betyget E

        public void add_passenger()
        {
            int newAge = 0;
            double newHeight = 0;
            string newSex = "";

            Console.Clear();
            Console.WriteLine("Lägg till Pasagerare");
            if (antal_passagerare <= 25)
            {
                // loop for adding passenger age
                while (true)
                {
                    //To get correct input from user
                    try
                    {
                        Console.WriteLine("Skriv in passagerans ålder: ");
                        newAge = Convert.ToInt32(Console.ReadLine());
                        if (newAge <= 0 || newAge >= 116) //Oldest person alive is 116 years old
                        {
                            Console.WriteLine("Skriv in en giltig ålder");
                            Console.Clear();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Skrin in en giltig siffra");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Skriv in passagerarens längd: ");
                        newHeight = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Skrin in en giltig siffra");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Är passageraren [M]an eller [K]vinna?: ");
                        newSex = Console.ReadLine().ToUpper();

                        if (newSex == "M" || newSex == "K")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Skriv in ett giltigt kön");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Skriv in ett giltigt kön");
                    }
                }
                for (int i = 0; i < plats.Length - 1; i++)
                {
                    if (plats[i] == null)
                    {
                        plats[i] = new Passagerare(newAge, newHeight, newSex);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            else
            {
                Console.WriteLine("Bussen är full");
            }

            //Lägg till passagerare. Här skriver man då in ålder men eventuell annan information.
            //Om bussen är full kan inte någon passagerare stiga på
        }

        public void print_buss()
        {
            //Skriv ut alla värden ur vektorn. Alltså - skriv ut alla passagerare
        }

        /*public int calc_total_age()
        {
            //Beräkna den totala åldern. 
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void
        }

        //Metoder för betyget C

        public double calc_average_age()
        {
            //Betyg C
            //Beräkna den genomsnittliga åldern. Kanske kan man tänka sig att denna metod ska returnera något annat värde än heltal?
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void
        }

        public int max_age()
        {

            //Betyg C
            //ta fram den passagerare med högst ålder. Detta ska ske med egen kod och är rätt klurigt.
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void
        }

        public void find_age()
        {
            //Visa alla positioner med passagerare med en viss ålder
            //Man kan också söka efter åldersgränser - exempelvis 55 till 67
            //Betyg C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)

        }*/

        public void sort_buss()
        {
            //Sortera bussen efter ålder. Tänk på att du inte kan ha tomma positioner "mitt i" vektorn.
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
            //Man ska kunna sortera vektorn med bubble sort
        }

        //Metoder för betyget A
        //NOTERA! För betyget A ska du inte jobba med heltal i vektorn utan objekt av klassen passagerare (som du skapar)


        public void print_sex()
        {
            //Betyg A
            //Denna metod är nödvändigtvis inte svårare än andra metoder men kräver att man skapar en klass för passagerare.
            //Skriv ut vilka positioner som har manliga respektive kvinnliga passagerare.
        }
        public void poke()
        {
            //Betyg A
            //Vilken passagerare ska vi peta på?
            //Denna metod är valfri om man vill skoja till det lite, men är också bra ur lärosynpunkt.
            //Denna metod ska anropa en passagerares metod för hur de reagerar om man petar på dom (eng: poke)
            //Som ni kan läsa i projektbeskrivningen så får detta beteende baseras på ålder och kön.
        }

        public void getting_off()
        {
            //Betyg A
            //En passagerare kan stiga av
            //Detta gör det svårare vid inmatning av nya passagerare (som sätter sig på första lediga plats)
            //Sortering blir också klurigare
            //Den mest lämpliga lösningen (men kanske inte mest realistisk) är att passagerare bakom den plats..
            //.. som tillhörde den som lämnade bussen, får flytta fram en plats.
            //Då finns aldrig någon tom plats mellan passagerare.
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Denna del körs först! 
            //Denna del av koden kan upplevas väldigt förvirrande. Men i sådana fall är det bara att "skriva av".
            //Programmet skapar ett så kallat objekt av klassen "Buss". Det är det objekt vi kommer jobba med.
            //Följande rad skapar en buss:
            var minbuss = new Buss();
            //Följande rad anropar metoden Run() som finns i vårt nya buss-objekt.
            minbuss.Run();
            //När metoden Run() tar slut så kommer koden fortsätta här. Då är programmet slut
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
