using PlateGenerator_Model;

namespace PlateGenerator_Service.Helper
{
    public static class Message
    {
        public const string NumberPlateMessage = "Add count of plate number: ";
        public const string CharPlateMessage = "Add count of plate char: ";
        public const string PrintMessage = "--- Printing plate ---";
        public const string PrintNewPlateMessage = "--- Printing new Hungarian plate ---";
        public const string PrintOldPlateMessage = "--- Printing old Hungarian plate ---";
        public static string PrintPlate(Plate plate) => $"{plate.Chars}-{plate.Number}";
    }

    public static class PatternMessage
    {
        public const string AbstractFactory = "*** Abstract Factory *** \nprovides an interface for creating families of related or dependent objects without specifying their concrete classes.\n";
        public const string Builder = "*** Builder pattern *** \nSeparates the construction of a complex object from its representation so that the same construction process can create different representations.\n";
    }
}
