using PlateGenerator_Service.AbstractFactory;
using PlateGenerator_Service.Builder;
using PlateGenerator_Service.Director;
using PlateGenerator_Service.Helper;
using System;

namespace PlateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PatternMessage.Builder);
            Console.Write(Message.CharPlateMessage);
            int charCount = Convert.ToInt32(Console.ReadLine());

            Console.Write(Message.NumberPlateMessage);
            int numberCount = Convert.ToInt32(Console.ReadLine());

            var builder = new PlateBuilder();
            var director = new PlateDirector(builder);

            director.BuildPlate(charCount, numberCount);

            var plate = builder.GetPlate();

            plate.PrintPlate();

            Console.WriteLine(PatternMessage.AbstractFactory);

            PlateFactory plateFactory = new HungarianPlateFactory(director, builder);

            PlateClient plateClient = new PlateClient(plateFactory);

            var oldPlate = plateClient.GetHungarianOldPlate();
            oldPlate.PrintOldPlate();

            var newPlate = plateClient.GetHungarianNewPlate();
            newPlate.PrintNewPlate();
        }
    }
}
