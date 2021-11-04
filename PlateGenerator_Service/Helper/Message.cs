using PlateGenerator_Model;

namespace PlateGenerator_Service.Helper
{
    public static class Message
    {
        public const string NumberPlateMessage = "Add count of plate number: ";
        public const string CharPlateMessage = "Add count of plate char: ";
        public const string PrintMessage = "--- Printing plate ---";
        public static string PrintPlate(Plate plate) => $"{plate.Chars}-{plate.Number}";
    }
}
