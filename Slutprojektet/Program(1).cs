/*Hjälpkod för att komma igång
 * Notera att båda klasserna är i samma fil för att det ska underlätta.
 * Om programmet blir större bör man ha klasserna i separata filer såsom jag går genom i filmen
 * Då kan det vara läge att ställa in startvärden som jag gjort.
 * Man kan också skriva ut saker i konsollen i konstruktorn för att se att den "vaknar
 * Denna kod hjälper mest om du siktar mot betyget E och C
 * För högre betyg krävs mer självständigt arbete
 */
using System;
using System.Collections.Generic;
//Nedan är namnet på "namespace" - alltså projektet. 
//SKapa ett nytt konsollprojekt med namnet "Bussen" så kan ni kopiera över all koden rakt av från denna fil
namespace Bussen
{
    class Buss
    {

        Passagerare[] plats = new Passagerare[25];
        int antal_passagerare = 0;

        public void Run()
        {
            string[] menuOptions = new string[]
            {
                "1. Lägg till passagerare\t",
                "2. Skriv ut fullständig passagerarlista\t",
                "3. Skriv ut total ålder\t",
                "4. Beräkna medelålder eller medellängd\t",
                "5. Skriv ut äldsta passagerare\t",
                "6. Hitta passagerare i visst åldersspann\t",
                "7. Sortera passagera efter ålder\t",
                "8. Skriv ut passagerarnas kön\t",
                "9. Peta på en passagerare\t",
                "10. Ta bort en passagerare\t",
                "11. Avsluta\t"
            };
            int menuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("Welcome to the awesome Buss-simulator\n");
                Console.WriteLine("Navigera dig i menyn med hjälp av upp / ner pilarna\n");

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
                            Calc_total_age();
                            break;
                        case 3:
                            CalcAverage();
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
                            Environment.Exit(0);
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

            Console.Clear();
            Console.WriteLine("Lägg till Pasagerare");
            if (antal_passagerare <= 25)
            {
                int newAge;
                // loop for adding passenger age
                while (true)
                {
                    //To get correct input from user
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Skriv in passagerans ålder: ");
                        newAge = Convert.ToInt32(Console.ReadLine());
                        if (newAge <= 0 || newAge >= 116) //Oldest person alive is 116 years old
                        {
                            Console.Clear();
                            Console.WriteLine("Skriv in en giltig ålder");
                            Console.ReadKey();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Skrin in en giltig siffra");
                        Console.ReadKey();
                    }
                }
                double newHeight;
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Skriv in passagerarens längd i meter");
                        Console.WriteLine("Till exmepel 1,75\n");
                        newHeight = Convert.ToDouble(Console.ReadLine());

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Skrin in en giltig siffra");
                        Console.ReadKey();
                    }
                }
                string newSex;
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Är passageraren [M]an eller [K]vinna?: ");
                        newSex = Console.ReadLine().ToUpper();

                        if (newSex == "M")
                        {
                            newSex = "Man";
                            break;
                        }
                        else if (newSex == "K")
                        {
                            newSex = "Kvinna";
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Skriv in ett giltigt kön");
                            Console.ReadKey();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Skriv in ett giltigt kön");
                        Console.ReadKey();
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
                antal_passagerare++;

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
            Console.Clear();
            int platsnummer = 0;
            foreach (Passagerare person in plats)
            {
                platsnummer++;
                if (person == null)
                {
                    Console.WriteLine($"Plats nr {platsnummer} : Tom plats");
                }
                else
                {
                    Console.WriteLine($"Plats nr {platsnummer} : Passageraren är  {person.NewSex}, {person.NewHeight} meter lång och {person.NewAge} år");
                }

            }
            Console.ReadKey(true);

            //Skriv ut alla värden ur vektorn. Alltså - skriv ut alla passagerare
        }

        public int Calc_total_age()
        {
            Console.Clear();
            int sum = 0;
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;   // Seat is empty
                }
                else
                {
                    sum += person.NewAge;
                }

            }
            Console.WriteLine($"Den totala åldern är {sum} år");
            Console.ReadKey(true);
            return sum;

            //Beräkna den totala åldern. 
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void
        }

        //Metoder för betyget C

        public void CalcAverage()
        {
            bool keepGoing = true;

            do
            {
                Console.Clear();

                Console.WriteLine("Vill du ha medel[Å]lder eller [M]edelängd?");
                string answer = Console.ReadLine().ToUpper();


                if (answer == "Å")
                {
                    calc_average_age();
                    Console.WriteLine("Vill du gå tillbaka till huvudmenyn? J/N");
                    string input = Console.ReadLine();
                    if (input == "J")
                    {
                        keepGoing = false;
                    }
                    else
                        keepGoing = true;

                }
                else if (answer == "M")
                {
                    CalcAverageHeight();

                    Console.WriteLine("Vill du gå tillbaka till huvudmenyn? J/N");
                    string input = Console.ReadLine();
                    if (input == "J")
                    {
                        keepGoing = false;
                    }
                    else
                        keepGoing = true;
                }


            } while (keepGoing);

        }
        public void calc_average_age()
        {
            Console.Clear();

            double sum = 0;
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;
                }
                else
                {
                    sum += person.NewAge;
                }

            }
            double aver = sum / (double)antal_passagerare;
            Console.WriteLine($"Medelåldern på alla passagerare är {aver} år");
            Console.ReadKey(true);

            //Betyg C
            //Beräkna den genomsnittliga åldern. Kanske kan man tänka sig att denna metod ska returnera något annat värde än heltal?
            //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void
        }

        public void CalcAverageHeight()
        {
            Console.Clear();

            double sum = 0;
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;
                }
                else
                {
                    sum += person.NewHeight;
                }

            }
            double aver = sum / (double)antal_passagerare;
            Console.WriteLine($"Längden på alla passagerare är {aver} meter");
            Console.ReadKey(true);
        }

        public int max_age()
        {
            Console.Clear();
            int oldest = 0;
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;
                }
                else if (person.NewAge > oldest)
                {
                    oldest = person.NewAge;
                }

            }

            // Skriv ut det högsta värdet
            Console.WriteLine($"Det högsta värdet i vektorn är: {oldest}");
            Console.ReadKey(true);
            return oldest;
        }
        //Betyg C
        //ta fram den passagerare med högst ålder. Detta ska ske med egen kod och är rätt klurigt.
        //För att koden ska fungera att köra så måste denna metod justeras, alternativt att man temporärt sätter metoden med void


        public void find_age()
        {
            Console.Clear();
            Console.WriteLine("=== Average age ===");
            int numberOfPassengers = 0;
            int totalAgeOfPassengers = 0;
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;   // Seat is empty
                }
                else
                {
                    totalAgeOfPassengers += person.NewAge;
                    numberOfPassengers++;
                }
            }
            Console.WriteLine("The average age of the current passengers is {0}years.", totalAgeOfPassengers / numberOfPassengers);

            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
            //Visa alla positioner med passagerare med en viss ålder
            //Man kan också söka efter åldersgränser - exempelvis 55 till 67
            //Betyg C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)

        }

        public void sort_buss()
        {
            Console.Clear();
            Console.WriteLine("=== Sort the bus by age ===");

            List<Passagerare> temporarySortingList = new List<Passagerare>();

            // Adds all passengers in the temporary list
            foreach (Passagerare person in plats)
            {
                if (person == null)
                {
                    continue;
                }
                else
                {
                    temporarySortingList.Add(person);
                }
            }
            // Selection sort in temporary list
            for (int i = 0; i < temporarySortingList.Count; i++)
            {
                int currentIntex = i;
                for (int j = i + 1; j < temporarySortingList.Count; j++)
                {
                    if (temporarySortingList[j].NewAge < temporarySortingList[currentIntex].NewAge)
                    {
                        currentIntex = j;
                    }
                }
                if (currentIntex != i)
                {
                    Passagerare temporaryValueHolder = temporarySortingList[i];
                    temporarySortingList[i] = temporarySortingList[currentIntex];
                    temporarySortingList[currentIntex] = temporaryValueHolder;
                }
            }
            // Clear all seats
            Array.Clear(plats, 0, plats.Length - 1);
            // Add all passengers, now sorted in age
            for (int i = 0; i < temporarySortingList.Count; i++)
            {
                plats[i] = (temporarySortingList[i]);
            }
            // Print new passenger order
            int seatNumber = 0;
            foreach (Passagerare person in plats)
            {
                seatNumber++;
                if (person == null)
                {
                    Console.WriteLine("Seatnumber {0}: This seat is empty", seatNumber);
                }
                else
                {
                    Console.WriteLine("Seatnumber {0}: {1}, {2} years old, {3}.", seatNumber, person.NewAge, person.NewHeight, person.NewSex);
                }
            }

            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
            //Sortera bussen efter ålder. Tänk på att du inte kan ha tomma positioner "mitt i" vektorn.
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
            //Man ska kunna sortera vektorn med bubble sort
        }

        //Metoder för betyget A
        //NOTERA! För betyget A ska du inte jobba med heltal i vektorn utan objekt av klassen passagerare (som du skapar)


        public void print_sex()
        {
            int seatNumber = 0;

            Console.Clear();
            Console.WriteLine("=== Current genders on the bus ===");
            foreach (Passagerare person in plats)
            {
                seatNumber++;
                if (person == null)
                {
                    Console.WriteLine("Seatnumber {0}: This seat is empty", seatNumber);
                }
                else
                {
                    Console.WriteLine("Seatnumber {0}: Here sits a {1}", seatNumber, person.NewSex);
                }
            }
            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
        }
        //Betyg A
        //Denna metod är nödvändigtvis inte svårare än andra metoder men kräver att man skapar en klass för passagerare.
        //Skriv ut vilka positioner som har manliga respektive kvinnliga passagerare.

        public void poke()
        {
            Console.WriteLine("Vilken passagerare vill du peta på?");
            print_buss();
            // Switch case på platsnummer.
            //skicka platsnummer in i metoden
            // baserat på personen som sitter på platsen så körs react och skriver ut det som ska stå. 


            //Betyg A
            //Vilken passagerare ska vi peta på?
            //Denna metod är valfri om man vill skoja till det lite, men är också bra ur lärosynpunkt.
            //Denna metod ska anropa en passagerares metod för hur de reagerar om man petar på dom (eng: poke)
            //Som ni kan läsa i projektbeskrivningen så får detta beteende baseras på ålder och kön.
        }

        public void getting_off()
        {
            // Defining data
            int platsNummer = 0;
            int index = -1;

            Console.Clear();
            Console.WriteLine("=== Remove passenger ===");
            // Prints current passengers
            foreach (Passagerare person in plats)
            {
                platsNummer++;
                if (person == null)
                {
                    Console.WriteLine("Seatnumber {0}: This seat is empty", platsNummer);
                }
                else
                {
                    Console.WriteLine("Seatnumber {0}: {1}", platsNummer, person.NewAge);
                }
            }
            Console.WriteLine("Choose a seatnumber for the \n" +
                              "passenger to be removed.");
            // User input
            while (true)
            {
                try
                {
                    index = Convert.ToInt32(Console.ReadLine()) - 1; // -1 to get array index instead of seat number
                    if (index < 0 || index >= plats.Length)
                    {
                        Console.WriteLine("Please choose a seat between 1 and {0}.", plats.Length);
                    }
                    else if (plats[index] == null)
                    {
                        Console.WriteLine("That seat is already empty, please choose another one.");
                    }
                    else
                    {
                        antal_passagerare--;
                        break;  // Successful input
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please write an integer.");
                }
            }
            // Output
            Console.WriteLine("\n{0} has now left the bus and \n" +
                              "seat {1} is now free to use.", plats[index].NewAge, index + 1);
            plats[index] = null;

            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
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

