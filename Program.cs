using System;

namespace JamFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                JamData jamData = new JamData();

                Console.WriteLine($"Number of blueberry jams: {jamData.BlueberryCount}");
                Console.WriteLine($"Number of peaches jams: {jamData.PeachesCount}");
                Console.WriteLine($"Number of rose hips jams: {jamData.RoseHipsCount}");
            }catch(Exception)
            {
                Console.WriteLine("Invalid input is given!");
            }
        }
    }
}
