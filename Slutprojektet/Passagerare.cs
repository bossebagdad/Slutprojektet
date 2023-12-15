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

        public int NewAge
        { 
            get { return age; }
            set { age = value; }
        }

        public double NewHeight 
        {
            get { return height; }
            set { height = value; }
        }
        public string NewSex 
        {
            get {  return sex; }
            set {  sex = value; }
        }

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
                Console.WriteLine("Platsen är tom");
            }

        }


    }
}
