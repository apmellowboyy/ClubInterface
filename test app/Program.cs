using System;
namespace Clubinterface
{
    interface ICLub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName();
    }
    class Program
    {
        class patron : ICLub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public patron()
            {
                Id = 0;
                FirstName = "";
                LastName = "";

            }
            public patron(int id, string FirstName, string LastName)
            {
                Id = id;
                FirstName = FirstName;
                LastName = LastName;

            }
            public string FullName()
            {
                return FirstName + " " + LastName;
            }
        }
        static void Main(string[] args)
        {
            patron stew = new patron();
            stew.Id = 26;
            stew.FirstName = "Stewart";
            stew.LastName = "Little";
            Console.WriteLine(stew.FullName() );

            Console.WriteLine();

            patron Blud = new patron();
            Blud.Id = 9;
            Blud.FirstName = "Blud";
            Blud.LastName = "Raymond";
            Console.WriteLine( Blud.FullName() );

            Console.WriteLine();

            patron Dwayne = new patron();
            Dwayne.Id = 75;
            Dwayne.FirstName = "Dwayne";
            Dwayne.LastName = "Johnson";
            Console.WriteLine(Dwayne.FullName());

            Console.WriteLine();

            patron Lisa = new patron();
            Lisa.FirstName= "Lisa";
            Lisa.LastName = "Balbach";
            Console.WriteLine(Lisa.FullName());

            Console.WriteLine();

            patron Ethan = new patron();
            Ethan.FirstName = "Ethan";
            Ethan.LastName = "Barnes";
            Console.WriteLine(Ethan.FullName());

            Console.WriteLine();

            patron Doug = new patron();
            Doug.FirstName = "Doug";
            Doug.LastName = "Bolter";
            Console.WriteLine(Doug.FullName());

            Console.WriteLine();

            patron Ronald = new patron();
            Ronald.FirstName = "Ronald";
            Ronald.LastName = "McDonald";
            Console.WriteLine(Ronald.FullName());

            Console.WriteLine();
        }
    }
}

