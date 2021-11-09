using PlateGenerator_Model;
using PlateGenerator_Service.AbstractFactory.AbstractProduct;

namespace PlateGenerator_Service.AbstractFactory
{
    public abstract class PlateFactory
    {
        public abstract AbstractOldPlate CreateOldPlate();
        public abstract AbstractNewPlate CreateNewPlate();
    }
}
