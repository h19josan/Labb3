using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    //Enum för olika kön som ska användas
    public enum Gender
    {
        Kvinna,
        Man,
        IckeBinär,
        Annan,
    }

    //Struct för olika hår inställningar
    public struct Hair
    {
        public string HairLength { get; set; }
        public string HairColor { get; set; }
        public override string ToString()
        {
            return $"Hårlängd: {HairLength}, Hårfärg: {HairColor}";
        }
    }

    //Klass för personen som vi hårdkodar
    public class Person
    {
        public Gender PersonGender { get; set; }
        public Hair PersonHair { get; set; }
        public DateTime BirthDate { get; set; }
        public string EyeColor { get; set; }
        public override string ToString()
        {
            return $"Kön: {PersonGender}, Hår: {PersonHair}, Födelsedag: {BirthDate.ToShortDateString()}, Ögonfärg: {EyeColor}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här lägger vi in värdena på en person
            Person person = new Person
            {
                PersonGender = Gender.Man,
                PersonHair = new Hair { HairLength = "Kort", HairColor = "Rosa" },
                BirthDate = new DateTime(2011, 3, 22),
                EyeColor = "Bruna"
            };
            //Här skriver vi ut informationen som finns lagrad om personen
            Console.WriteLine(person.ToString());

            //Vi ser till att man hinner läsa informationen som visas i konsolfönstret innan det stängs
            Console.WriteLine("Tryck på Enter för att gå vidare.");
            Console.ReadLine();

        }
    }
}
