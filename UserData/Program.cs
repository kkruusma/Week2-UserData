using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat (number=int, tekst=string);
            //programm arvutab kasutaja vanust (konverteerib arvuks=Convert.ToInt32);
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2021 - YearOfBirth;
            
            //Üks võimalus teksti kuvamiseks konsoolis:
            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //Teine võimalus teksti kuvamiseks konsoolis:
            //string interpolation - tuleb kasutada $ ja {}
            Console.WriteLine($"Oled {UserAge} aastat vana.");

        }
    }
}
