using ders5odev5GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev5GameProject.Concrete
{
    internal class GamerManager
    {
        public List<Gamer> gamers = [];
        public Gamer gamer = new();
        public string deleteName;
        public Gamer[] Add()
        {
            Console.WriteLine("Gamer Adini Giriniz");
            gamer.FirstName = Console.ReadLine();
            Console.WriteLine("Gamer Soyadını giriniz");
            gamer.LastName = Console.ReadLine();
            Console.WriteLine("Gamer Dogum Tarihini Giriniz");
            gamer.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gamer Tc sini Giriniz");
            gamer.IdentityNumber = Convert.ToInt64(Console.ReadLine());
            gamers.Append(gamer);
            return gamers;
            while (gamers.Length > 5) {
                Console.WriteLine("5 sayısını aştınız");
                break;
            }

        }
        public int Delete(Gamer gamer)
        {
            
             Console.WriteLine("silinecek ismi giriniz");
            deleteName=Console.ReadLine();
            for (int i = 0; i < gamers.Length; i++)
            {
               if( gamers[i].FirstName == deleteName)
                    gamers.Re

            }
            return gamers.Length;}

}



