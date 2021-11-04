using PlateGenerator_Model;

namespace PlateGenerator_Service.Builder
{
    public interface IPlateBuilder
    {
        IPlateBuilder BuildPlateNumber(int count);
        IPlateBuilder BuildPlateChar(int count);
        Plate GetPlate();
    }
}
