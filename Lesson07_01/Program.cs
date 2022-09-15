using System;
//Sukurti struktūrą Mokinys su laukais 
//vardas, pavarde, kurso pradžia ir 
//kurso pabaiga.
//Sukurti kintamąjį mokinys užpildyti 
//laukus ir išvesti į konsolę
namespace Lesson07_01
{
    
    struct Mokinys 
    {
        public string Vardas;
        public string Pavarde;
        public DateTime KursoPradzia;
        public DateTime KursoPabaiga;

        public Mokinys(string vardas, string pavarde, DateTime kursoPradzia, DateTime kursoPabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            KursoPradzia = kursoPradzia;
            KursoPabaiga = kursoPabaiga;
        }
    }
    internal class Program   
    {        
        static void Main(string[] args)
        {
            Mokinys mokinysPirmas = new Mokinys("Vardenis", "Pavardenis", DateTime.Today, DateTime.Now);
            Console.WriteLine(mokinysPirmas.Pavarde);
            Console.WriteLine(mokinysPirmas.Vardas); 
            Console.WriteLine(mokinysPirmas.KursoPradzia);
            Console.WriteLine(mokinysPirmas.KursoPabaiga);
        }
    }
}
