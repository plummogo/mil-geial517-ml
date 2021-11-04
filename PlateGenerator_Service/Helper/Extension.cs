using PlateGenerator_Model;
using System;

namespace PlateGenerator_Service.Helper
{
    public static class Extension
    {
        private static string _container;
        private static int _index;

        public static void NextInit(this Random rnd)
        {
            _index = 0;
            _container = string.Empty;
        }

        public static string NextChar(this Random rnd, int count)
        {
            if (_index < count)
            {
                _index++;
                _container += Convert.ToChar(rnd.Next('A', 'Z'));

                rnd.NextChar(count);
            }

            return _container;
        }

        public static string NextNumber(this Random rnd, int count)
        {
            if (_index < count)
            {
                _index++;
                _container += rnd.Next(0, 9);

                rnd.NextNumber(count);
            }

            return _container;
        }

        public static void PrintPlate(this Plate plate)
        {
            Console.WriteLine();
            Console.WriteLine(Message.PrintMessage);
            Console.WriteLine(Message.PrintPlate(plate));

            Console.ReadLine();
        }
    }
}
