using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamFactory
{
    class JamData
    {
        public int BlueberryCount { get; set; }
        public int PeachesCount { get; set; }
        public int RoseHipsCount { get; set; }

        private int n;
        private string numberSequence;
        int[] numbers;
        int[] jamType;
        public JamData()
        {
            BlueberryCount = 0;
            PeachesCount = 0;
            RoseHipsCount = 0;
            Console.Write("Enter number sequence length: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number sequence with spaces in between numbers:");
            numberSequence = Console.ReadLine();
            if(numberSequence.Length/2 + 1 != n)
            {
                throw new IndexOutOfRangeException("Number sequence has more numbers than stated!");
            }

            numbers = numberSequence.Split(' ').Select(int.Parse).ToArray();

            SequenceToJamTypesNumbers();

            for(int i = 0; i < jamType.Length; i++)
            {
                JamTypesNumbersToNumberOfTypes(jamType[i]);
            }
        }

        void JamTypesNumbersToNumberOfTypes(int num)
        {
            if(num % 7 == 0)
            {
                BlueberryCount++;
            }
            else if(num % 13 == 0)
            {
                PeachesCount++;
            }
            else if(num % 17 == 0)
            {
                RoseHipsCount++;
            }
        }

        void SequenceToJamTypesNumbers()
        {
            int index = 0;
            for (int i = 3; i < numbers.Length-3; i += 8, index++ )
            {
                jamType[index] = numbers[i] * 1000 + numbers[i + 1] * 100 + numbers[i + 2] * 10 + numbers[i + 3];
            }
        }


    }
}
