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
        private int[] numbers;
        private int[] jamType;
        public JamData()
        {
            BlueberryCount = 0;
            PeachesCount = 0;
            RoseHipsCount = 0;

            InputData();

            SequenceToJamTypesNumbers();

            for(int i = 0; i < jamType.Length; i++)
            {
                JamTypesNumbersToNumberOfTypes(jamType[i]);
            }
        }

        //Inputs data and validates it.
        void InputData()
        {
            Console.Write("Enter number sequence length: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number sequence with spaces in between numbers:");
            numberSequence = Console.ReadLine();
            if (numberSequence.Length / 2 + 1 != n)
            {
                throw new IndexOutOfRangeException("Number sequence has more numbers than stated!");
            }

            numbers = numberSequence.Split(' ').Select(int.Parse).ToArray();

            jamType = new int[numbers.Length / 8];
        }

        //Checks which flavor does the four digit number corespond to.
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

        //Takes the four specific numbers from the numbers array
        //and writes them to the jamType array.
        void SequenceToJamTypesNumbers()
        {
            int index = 0;
            for (int i = 3; i < numbers.Length-3 && index < jamType.Length; i += 8, index++ )
            {
                jamType[index] = numbers[i] * 1000 + numbers[i + 1] * 100 + numbers[i + 2] * 10 + numbers[i + 3];
            }
        }


    }
}
