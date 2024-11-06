namespace DZ411
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Worker и т.д.
            Security security = new("Ben", 1000, 123, "Street 12", "AK47");
            Engineer engineer = new("Gena", 3000, 234, "Street 8");
            Manager manager = new("Ulyana", 2500, 456, "Street 007", 100);
            President president = new("Mikita", 0, 1, "Main Street 01", 5);

            Worker[] workers = { security, engineer, manager, president };

            foreach (Worker worker in workers)
            {
                worker.Print();
                worker.Work();
            }
            Console.WriteLine();
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker + "\n");
            }
            #endregion

            #region Device и т.д.

            Violin violin = new("Fafa-111", "Lorem ipsum", "Four three", "LA-1-23");
            Ukulele ukulele = new("Row", "Ruruu", "Five six", 100);
            Trombone trombone = new("Zaza", "fsdf", "Good", "Big");
            Cello cello = new("Fdsf", "fsdfs", "Bad", "Very big");

            MusicalInstrument[] massive = [violin, trombone, cello, ukulele];

            foreach(MusicalInstrument instrument in massive)
            {
                instrument.Sound();
                instrument.History();
                instrument.Desc();
                Console.WriteLine(instrument + "\n");
            }
            #endregion
        }
    }
}
